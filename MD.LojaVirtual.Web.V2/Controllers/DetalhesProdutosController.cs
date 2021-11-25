//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Web.Mvc;
using AutoMapper;
using MD.LojaVirtual.Dominio.Repositorio;
using MD.LojaVirtual.Web.V2.Models;

namespace MD.LojaVirtual.Web.V2.Controllers
{

  [RoutePrefix("produto")]
  public class DetalhesProdutoController : Controller
  {
    [Route("{codigo}/{marca}/{produto}/{corcodigo}")]
    public ActionResult Detalhes(string codigo, string corCodigo)
    {
      var repositorio = new DetalhesProdutoRepositorio();
      var produto = repositorio.ObterProdutoModelo(codigo, corCodigo);
      var model = Mapper.DynamicMap<DetalhesProdutoViewModel>(produto);
      model.CoresList = new SelectList(produto.Cores, "CorCodigo", "CorDescricao", corCodigo);
      model.TamanhoList = new SelectList(produto.Tamanhos, "TamanhoCodigo", "TamanhoDescricaoResumida");
      model.Breadcrumb = repositorio.ObterBreadCrumb(produto.Produto.ProdutoModeloCodigo);
      return View(model);
    }

  }
}