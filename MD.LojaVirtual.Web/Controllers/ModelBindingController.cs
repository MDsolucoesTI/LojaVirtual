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
using MD.LojaVirtual.Dominio.Entidades;

namespace MD.LojaVirtual.Web.Controllers
{
  public class ModelBindingController : Controller
  {
    public ActionResult Index()
    {
      return View(new Produto());
    }

    [HttpPost]
    public ActionResult Editar([Bind(Include = "Nome")] Produto produt)
    {
      return RedirectToAction("Index");
    }
  }
}