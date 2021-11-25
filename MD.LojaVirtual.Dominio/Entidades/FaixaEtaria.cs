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
using System.Threading.Tasks;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class FaixaEtaria
  {
    public int FaixaEtariaId { get; set; }
    public string FaixaEtariaCodigo { get; set; }
    public string FaixaEtariaDescricao { get; set; }
  }
}
