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
using System.Web.UI;
using MD.LojaVirtual.Dominio.Repositorio;

namespace MD.LojaVirtual.Web.V2.Controllers
{
  public class CategoriaController : Controller
  {
    private CategoriaRepositorio _repositorio;

    [OutputCache(Duration = 3600, Location = OutputCacheLocation.Server, VaryByParam = "none")]
    public JsonResult ObterEsportes()
    {
      _repositorio = new CategoriaRepositorio();
      var cat = _repositorio.ObterCategorias();

      var categoria = from c in cat
                      select new
                      {
                        c.CategoriaDescricao,
                        CategoriaDescricaoSeo = c.CategoriaDescricao.ToSeoUrl(),
                        c.CategoriaCodigo

                      };
      return Json(categoria, JsonRequestBehavior.AllowGet);
    }
  }
}