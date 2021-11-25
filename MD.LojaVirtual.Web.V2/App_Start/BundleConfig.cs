//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Web;
using System.Web.Optimization;

namespace MD.LojaVirtual.Web.V2
{
  public class BundleConfig
  {
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new StyleBundle("~/css").Include(
                "~/css/*.css"));

      bundles.Add(new ScriptBundle("~/js").Include(
               "~/js/jquery.js",
                "~/js/bootstrap.js"));

      // <!-- SmartMenu http://www.smartmenus.org/ -->
      bundles.Add(new StyleBundle("~/Content/startmenu").Include(
           "~/Content/sm-core-css.css",
             // "~/Content/sm-simple/sm-simple.css"
             "~/Content/sm-mint/sm-mint.css"
       ));

      bundles.Add(new ScriptBundle("~/Scripts/startmenu").Include(
          "~/js/jquery.navgoco.js",
          "~/Scripts/jquery.smartmenus.js"));

      bundles.Add(new ScriptBundle("~/Scripts/jsprojetos").Include(
              "~/Scripts/menu.js"));

      bundles.Add(new ScriptBundle("~/Scripts/detalhesproduto").Include(
         "~/js/jquery.elevatezoom.js",
           "~/Scripts/detalhesProduto.js"));

      BundleTable.EnableOptimizations = false;
    }
  }
}
