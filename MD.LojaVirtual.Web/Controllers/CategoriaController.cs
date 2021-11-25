//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MD.LojaVirtual.Dominio.Repositorio;

namespace MD.LojaVirtual.Web.Controllers
{
  public class CategoriaController : Controller
  {
    private ProdutosRepositorio _repositorio;
    public PartialViewResult Menu(string categoria = null)
    {
      ViewBag.CategoriaSelecionada = categoria;
      _repositorio = new ProdutosRepositorio();
      IEnumerable<string> categorias = _repositorio.Produtos
          .Select(c => c.Categoria)
          .Distinct()
          .OrderBy(c => c);
      return PartialView(categorias);
    }
  }
}