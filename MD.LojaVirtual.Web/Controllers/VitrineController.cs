//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MD.LojaVirtual.Dominio.Entidades;
using MD.LojaVirtual.Dominio.Repositorio;
using MD.LojaVirtual.Web.Models;

namespace MD.LojaVirtual.Web.Controllers
{

  public class VitrineController : Controller
  {
    private ProdutosRepositorio _repositorio;
    public int ProdutosPorPagina = 12;

    [Route("DetalhesProduto/{id}/{produto}")]
    public ViewResult Detalhes(int id)
    {
      _repositorio = new ProdutosRepositorio();
      Produto produto = _repositorio.ObterProduto(id);
      return View(produto);
    }

    public ViewResult ListaProdutos(string categoria)
    {
      _repositorio = new ProdutosRepositorio();
      var model = new ProdutosViewModel();
      var rnd = new Random();
      if (categoria != null)
      {
        model.Produtos = _repositorio.Produtos
            .Where(p => p.Categoria == categoria)
            .OrderBy(x => rnd.Next()).ToList();
      }
      else
      {
        model.Produtos = _repositorio.Produtos
            .OrderBy(x => rnd.Next())
            .Take(ProdutosPorPagina).ToList();
      }
      return View(model);
    }

    [Route("Vitrine/ObterImagem/{produtoid}")]
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