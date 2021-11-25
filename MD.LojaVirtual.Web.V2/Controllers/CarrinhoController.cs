//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using MD.LojaVirtual.Dominio.Entidades;
using MD.LojaVirtual.Dominio.Repositorio;
using MD.LojaVirtual.Web.Models;
using MD.LojaVirtual.Web.V2.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Net.Http;
using MD.LojaVirtual.Dominio.Entidades.Pagamento;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace MD.LojaVirtual.Web.Controllers
{
  public class CarrinhoController : Controller
  {
    private MDProdutosRepositorio _repositorio = new MDProdutosRepositorio();
    private ClientesRepositorio _clientesRepositorio = new ClientesRepositorio();
    private PedidosRepositorio _pedidosRepositorio = new PedidosRepositorio();

    public ViewResult Index(Carrinho carrinho, string returnurl)
    {
      return View(new CarrinhoViewModel
      {
        Carrinho = carrinho,
        ReturnUrl = returnurl
      });
    }

    public PartialViewResult Resumo(Carrinho carrinho)
    {
      return PartialView(carrinho);
    }

    public RedirectToRouteResult Adicionar(Carrinho carrinho, int quantidade,
        string produto, string Cor, string Tamanho, string returnUrl)
    {
      MDProduto prod = _repositorio.ObterProduto(produto, Cor, Tamanho);

      if (prod != null)
      {
        carrinho.AdicionarItem(prod, quantidade);

      }

      return RedirectToAction("Index", "Nav");

    }

    public RedirectToRouteResult Remover(Carrinho carrinho, int produtoId, string returnUrl)
    {
      MDProduto produto = _repositorio.Produtos
          .FirstOrDefault(p => p.ProdutoId == produtoId);

      if (produto != null)
      {
        carrinho.RemevorItem(produto);
      }

      return RedirectToAction("Index", "Nav");
    }

    [Authorize]
    public ViewResult FecharPedido()
    {
      Pedido novoPedido = new Pedido();
      novoPedido.ClienteId = User.Identity.GetUserId();
      novoPedido.Cliente = _clientesRepositorio
          .ObterCliente(User.Identity.GetUserId());

      return View(novoPedido);
    }

    [HttpPost]
    [Authorize]
    [ValidateAntiForgeryToken]
    public async System.Threading.Tasks.Task<ActionResult> FecharPedido(Carrinho carrinho, Pedido pedido)
    {
      if (!carrinho.ItensCarrinho.Any())
      {
        ModelState.AddModelError("", "Não foi possível concluir o pedido, seu carrinho está vazio!");
      }

      if (ModelState.IsValid)
      {
        pedido.ProdutosPedido = new List<ProdutoPedido>();
        foreach (var item in carrinho.ItensCarrinho)
        {
          pedido.ProdutosPedido.Add(new ProdutoPedido()
          {
            Quantidade = item.Quantidade,
            ProdutoId = item.Produto.ProdutoId
          });
        }
        pedido.Pago = false;
        pedido = _pedidosRepositorio.SalvarPedido(pedido);
        pedido.Cliente = _clientesRepositorio.ObterCliente(pedido.ClienteId);
        foreach (var produto in pedido.ProdutosPedido)
        {
          produto.Produto = _repositorio.Produtos
              .Where(p => p.ProdutoId == produto.ProdutoId)
              .FirstOrDefault();
        }

        using (var client = new HttpClient())
        {
          client.BaseAddress = new System.Uri("https://ws.sandbox.pagseguro.uol.com.br");
          client.DefaultRequestHeaders.Clear();

          var pedidoPagSeguro = new PagamentoPagSeguro(
              pedido,
              "http://localhost:42028/Carrinho/PedidoConcluido?pedidoId=" + pedido.Id,
              Request.UserHostAddress);
          XmlSerializer serializer = new XmlSerializer(typeof(PagamentoPagSeguro));

          StreamContent content;
          using (var stream = new MemoryStream())
          {
            using (XmlWriter textWriter = XmlWriter.Create(stream))
            {
              serializer.Serialize(textWriter, pedidoPagSeguro);
            }

            stream.Seek(0, SeekOrigin.Begin);
            content = new StreamContent(stream);
            var test = await content.ReadAsStringAsync();

            content.Headers.Add("Content-Type", "application/xml");

            var response = await client.PostAsync(
                "v2/checkouts-qrcode/?email=hmgasparotto@hotmail.com&token=8BF8F5C11A214599912ED733EC4C885D",
                content);
            if (response.IsSuccessStatusCode)
            {
              string resultContent = await response.Content.ReadAsStringAsync();
              XmlSerializer returnSerializer = new XmlSerializer(typeof(ReceivedPagSeguro));
              using (TextReader reader = new StringReader(resultContent))
              {
                var retorno = (ReceivedPagSeguro)returnSerializer.Deserialize(reader);
                return Redirect("https://sandbox.pagseguro.uol.com.br/v2/checkout/payment.html?code=" + retorno.Code);
              }
            }
          }
        }


        return RedirectToAction("PedidoConcluido", new { pedidoId = pedido.Id });
      }
      else
      {
        return View(pedido);
      }

    }

    public ViewResult PedidoConcluido(Carrinho carrinho, int pedidoId)
    {
      EmailConfiguracoes email = new EmailConfiguracoes
      {
        EscreverArquivo = bool.Parse(ConfigurationManager.AppSettings["Email.EscreverArquivo"] ?? "false")
      };

      EmailPedido emailPedido = new EmailPedido(email);

      var pedido = _pedidosRepositorio.ObterPedido(pedidoId);
      pedido.Pago = true;
      _pedidosRepositorio.SalvarPedido(pedido);

      emailPedido.ProcessarPedido(carrinho, pedido);
      carrinho.LimparCarrinho();

      return View(pedido);
    }
  }
}