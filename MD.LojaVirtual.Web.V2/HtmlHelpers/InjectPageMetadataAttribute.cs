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
using System.Web.Configuration;
using System.Web.Mvc;

namespace MD.LojaVirtual.Web.V2.HtmlHelpers
{
  public interface IPageMetadata
  {
    string PageTitle { get; }
    string MetaKeywords { get; }
    string MetaDescription { get; }
  }


  public class InjectPageMetadataAttribute : ActionFilterAttribute
  {
    public override void OnActionExecuted(ActionExecutedContext filterContext)
    {

      var viewResult = filterContext.Result as ViewResult;

      if (viewResult == null) return;

      var settings = WebConfigurationManager.AppSettings;

      var title = viewResult.ViewBag.Title ?? settings["MetaTitle"];
      var description = viewResult.ViewBag.MetaDescription ?? settings["MetaDescription"];
      var keywords = viewResult.ViewBag.MetaKeywords ?? settings["MetaKeywords"];

      var metadata = viewResult.Model as IPageMetadata;

      if (metadata != null)
      {
        title = metadata.PageTitle ?? title;
        description = metadata.MetaDescription ?? description;
        keywords = metadata.MetaKeywords ?? keywords;
      }

      viewResult.ViewBag.Title = title;
      viewResult.ViewBag.MetaDescription = description;
      viewResult.ViewBag.MetaKeywords = keywords;

      base.OnActionExecuted(filterContext);
    }
  }
}