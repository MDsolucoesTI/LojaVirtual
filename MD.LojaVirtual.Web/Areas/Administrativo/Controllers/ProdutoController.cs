//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Linq;
using System.Web;
using System.Web.Mvc;
using MD.LojaVirtual.Dominio.Entidades;
using MD.LojaVirtual.Dominio.Repositorio;

namespace MD.LojaVirtual.Web.Areas.Administrativo.Controllers
{

  [Authorize]
  public class ProdutoController : Controller
  {
    private ProdutosRepositorio _repositorio;

    public ActionResult Index()
    {
      _repositorio = new ProdutosRepositorio();
      var produtos = _repositorio.Produtos;
      return View(produtos);
    }

    public ViewResult Alterar(int produtoId)
    {
      _repositorio = new ProdutosRepositorio();
      Produto produto = _repositorio.Produtos
          .FirstOrDefault(p => p.ProdutoId == produtoId);

      return View(produto);
    }

    [HttpPost]
    public ActionResult Alterar(Produto produto, HttpPostedFileBase image = null)
    {
      if (ModelState.IsValid)
      {
        if (image != null)
        {
          produto.ImagemMimeType = image.ContentType;
          produto.Imagem = new byte[image.ContentLength];
          image.InputStream.Read(produto.Imagem, 0, image.ContentLength);
        }
        _repositorio = new ProdutosRepositorio();
        _repositorio.Salvar(produto);
        TempData["mensagem"] = string.Format("{0} foi salvo com sucesso", produto.Nome);
        return RedirectToAction("Index");
      }
      return View(produto);
    }

    public ViewResult NovoProduto()
    {
      return View("Alterar", new Produto());
    }

    [HttpPost]
    public JsonResult Excluir(int produtoId)
    {
      string mensagem = string.Empty;
      _repositorio = new ProdutosRepositorio();
      Produto prod = _repositorio.Excluir(produtoId);
      if (prod != null)
      {
        mensagem = string.Format("{0} excluído com sucesso", prod.Nome);
      }
      return Json(mensagem, JsonRequestBehavior.AllowGet);
    }

    public FileContentResult ObterImagem(int produtoId)
    {
      _repositorio = new ProdutosRepositorio();
      Produto prod = _repositorio.Produtos
          .FirstOrDefault(p => p.ProdutoId == produtoId);
      if (prod != null)
      {
        return File(prod.Imagem, prod.ImagemMimeType);
      }
      return null;
    }
  }
}