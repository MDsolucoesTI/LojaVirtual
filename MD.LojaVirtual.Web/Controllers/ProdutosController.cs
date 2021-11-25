//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MD.LojaVirtual.Dominio.Repositorio;

namespace MD.LojaVirtual.Web.Controllers
{
  public class ProdutosController : Controller
  {
    private ProdutosRepositorio _repositorio;
    //[Route("produtos/obter")]
    public ActionResult Index()
    {
      _repositorio = new ProdutosRepositorio();
      var produtos = _repositorio.Produtos.Take(3);
      return View(produtos);
    }
  }
}