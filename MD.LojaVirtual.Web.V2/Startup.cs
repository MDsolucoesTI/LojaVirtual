//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using MD.LojaVirtual.Dominio.Repositorio;
using MD.LojaVirtual.Web.V2.Models;
using System;

[assembly: OwinStartupAttribute(typeof(MD.LojaVirtual.Web.V2.Startup))]
namespace MD.LojaVirtual.Web.V2
{
  public partial class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      app.CreatePerOwinContext(EfDbContext.Create);
      app.CreatePerOwinContext<MDUserManager>(MDUserManager.Create);
      app.CreatePerOwinContext<MDSignInManager>(MDSignInManager.Create);
      app.UseCookieAuthentication(new CookieAuthenticationOptions
      {
        AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
        LoginPath = new PathString("/cliente/login"),
        CookieName = "clienteLogin",
        CookiePath = "/",
        ExpireTimeSpan = TimeSpan.FromHours(12)
      });
    }
  }
}