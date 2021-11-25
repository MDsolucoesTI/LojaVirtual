//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MD.LojaVirtual.Web.V2.Helpers
{
  public class ImageHelper
  {
    private static AppSettingsReader _app;

    public static string CaminhoImagem()
    {
      _app = new AppSettingsReader();
      return _app.GetValue("Imagem", typeof(String)).ToString();
    }
  }
}