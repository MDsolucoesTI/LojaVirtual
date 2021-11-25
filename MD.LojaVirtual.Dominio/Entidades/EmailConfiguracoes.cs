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
using System.Text;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class EmailConfiguracoes
  {
    public bool UsarSsl = false;
    public string ServidorSmtp = "smtp.MD.com.br";
    public int ServidorPorta = 587;
    public string Usuario = "MD";
    public bool EscreverArquivo = false;
    public string PastaArquivo = @"c:\envioemail";
    public string De = "MD@MD.com.br";
    public string Para = "pedido@MD.com.br";
  }
}
