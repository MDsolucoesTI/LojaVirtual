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

namespace MD.LojaVirtual.Web.Controllers
{
  public class ClienteController : Controller
  {
    //[Route("Teste")]
    public ActionResult Index()
    {
      ViewBag.Controller = "Cliente";
      ViewBag.Action = "Index";
      return View();
    }
    [Route("Usuario/Adicionar/{usuario}/{id}")]
    public string Adicionar(string usuario, int id)
    {
      return string.Format("Usuário: {0}, ID {1}", usuario, id);
    }
  }
}