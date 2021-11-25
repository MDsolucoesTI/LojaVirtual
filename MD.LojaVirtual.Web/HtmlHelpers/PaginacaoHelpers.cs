﻿//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using MD.LojaVirtual.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace MD.LojaVirtual.Web.HtmlHelpers
{
  public static class PaginacaoHelpers
  {
    public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
    {
      StringBuilder resultado = new StringBuilder();
      for (int i = 1; i <= paginacao.TotalPagina; i++)
      {
        TagBuilder tag = new TagBuilder("a");
        tag.MergeAttribute("href", paginaUrl(i));
        tag.InnerHtml = i.ToString();

        if (i == paginacao.PaginaAtual)
        {
          tag.AddCssClass("selected");
          tag.AddCssClass("btn-primary");
        }
        tag.AddCssClass("btn btn-default");
        resultado.Append(tag);
      }
      return MvcHtmlString.Create(resultado.ToString());
    }
  }
}