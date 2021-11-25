//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Web.Optimization;

namespace MD.LojaVirtual.Web
{
  public class BundleConfig
  {

    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
          "~/Scripts/jquery-1.*"
          ));
      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
         "~/Scripts/jquery.validate*"
         ));
      bundles.Add(new StyleBundle("~/Content/css").Include(
      "~/Content/bootstrap.css",
       "~/Content/bootstrap-theme.css",
        "~/Content/erroEstilo.css"
      ));
      BundleTable.EnableOptimizations = false;
    }
  }
}