//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;

namespace MD.LojaVirtual.Web.Models
{
  public class Paginacao
  {
    public int ItensTotal { get; set; }
    public int ItensPorPagina { get; set; }
    public int PaginaAtual { get; set; }
    public int TotalPagina
    {
      get { return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina); }
    }
  }
}