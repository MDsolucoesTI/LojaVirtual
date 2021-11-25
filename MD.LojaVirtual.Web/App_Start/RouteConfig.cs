//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Web.Mvc;
using System.Web.Routing;

namespace MD.LojaVirtual.Web
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.MapMvcAttributeRoutes();
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
      routes.MapRoute(null, "", new { controller = "Vitrine", action = "ListaProdutos", categoria = (string)null, pagina = 1 });
      routes.MapRoute(null,
          "Pagina{pagina}",
          new { controller = "Vitrine", action = "ListaProdutos", categoria = (string)null }, new { pagina = @"\d+" });
      routes.MapRoute(null,
          "{categoria}", new { controller = "Vitrine", action = "ListaProdutos", pagina = 1 });
      routes.MapRoute(null,
          "{categoria}/Pagina{pagina}", new { controller = "Vitrine", action = "ListaProdutos" }, new { pagina = @"\d+" });
      routes.MapRoute(null, "{controller}/{action}");
    }
  }
}