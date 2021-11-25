//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity;
using MD.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MD.LojaVirtual.Web.V2.Controllers
{
  [Authorize]
  public class PedidosController : Controller
  {
    private PedidosRepositorio _repositorio = new PedidosRepositorio();

    // GET: Pedidos
    public ActionResult Index()
    {
      string id = User.Identity.GetUserId();
      var pedidos = _repositorio.ObterPedidos(id);

      return View(pedidos);
    }

    public ActionResult Details(int id)
    {
      var pedido = _repositorio.ObterPedido(id);
      return View(pedido);
    }
  }
}