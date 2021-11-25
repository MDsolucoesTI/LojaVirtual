//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using MD.LojaVirtual.Dominio.Entidades;
using MD.LojaVirtual.Web.V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MD.LojaVirtual.Web.V2.Controllers
{
  [RoutePrefix("cliente")]
  [Authorize]
  public class ClienteController : Controller
  {
    private MDUserManager _userManager;
    private MDSignInManager _signInManager;

    public ClienteController()
    {
    }

    public ClienteController(MDUserManager userManager, MDSignInManager signInManager)
    {
      UserManager = userManager;
      SignInManager = signInManager;
    }

    public MDUserManager UserManager
    {
      get
      {
        return _userManager ?? HttpContext.GetOwinContext().GetUserManager<MDUserManager>();
      }
      private set
      {
        _userManager = value;
      }
    }

    public MDSignInManager SignInManager
    {
      get
      {
        return _signInManager ?? HttpContext.GetOwinContext().Get<MDSignInManager>();
      }
      private set
      {
        _signInManager = value;
      }
    }

    // GET: Cliente
    public ActionResult Index()
    {
      return View();
    }

    [Route("cadastro")]
    [AllowAnonymous]
    public ActionResult CriaCliente()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Route("cadastro")]
    [AllowAnonymous]
    public async System.Threading.Tasks.Task<ActionResult> CriaCliente(Cliente model)
    {
      if (ModelState.IsValid)
      {
        model.Documento.Id = model.Id;
        model.Endereco.Id = model.Id;
        model.Telefone.Id = model.Id;
        var result = await UserManager.CreateAsync(model, model.Senha);
        if (result.Succeeded)
        {
          return RedirectToAction("Index", "Nav");
        }
        ModelState.AddModelError("", result.Errors.FirstOrDefault());
      }

      return View(model);
    }

    [Route("login")]
    [AllowAnonymous]
    public ActionResult Login(string returnUrl)
    {
      ViewBag.ReturnUrl = returnUrl;
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Route("login")]
    [AllowAnonymous]
    public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }

      var result = await SignInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, shouldLockout: false);
      switch (result)
      {
        case SignInStatus.Success:
          if (returnUrl != null)
            return Redirect(returnUrl);
          else
            return RedirectToAction("Index", "Nav");
        case SignInStatus.LockedOut:
          return View("Lockout");
        case SignInStatus.RequiresVerification:
        case SignInStatus.Failure:
        default:
          ModelState.AddModelError("", "Invalid login attempt.");
          return View(model);
      }
    }

    [HttpPost]
    [Route("logoff")]
    public ActionResult Logoff()
    {
      HttpContext.GetOwinContext()
          .Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
      return RedirectToAction("Index", "Nav");
    }
  }
}