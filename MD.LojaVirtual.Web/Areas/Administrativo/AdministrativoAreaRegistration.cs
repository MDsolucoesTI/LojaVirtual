//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Web.Mvc;

namespace MD.LojaVirtual.Web.Areas.Administrativo
{
  public class AdministrativoAreaRegistration : AreaRegistration
  {
    public override string AreaName
    {
      get
      {
        return "Administrativo";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      context.MapRoute(
          "Administrativo_default",
          "Administrativo/{controller}/{action}/{id}",
          new { controller = "Produto", action = "Index", id = UrlParameter.Optional },
          new[] { "MD.LojaVirtual.Web.Areas.Administrativo.Controllers" }
      );
    }
  }
}