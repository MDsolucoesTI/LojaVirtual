//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using MD.LojaVirtual.Dominio.Dto;
using MD.LojaVirtual.Dominio.Entidades;

namespace MD.LojaVirtual.Web.Models
{
  public class ModalidadeSubGrupoViewModel
  {
    public Modalidade Modalidade { get; set; }
    public IEnumerable<SubGrupoDto> SubGrupos { get; set; }

  }
}