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
using MD.LojaVirtual.Dominio.Entidades;

namespace MD.LojaVirtual.Web.V2.Models
{
  public class SubGrupoCategoriasViewModel
  {
    public SubGrupo SubGrupo { get; set; }

    public IEnumerable<Categoria> Categorias { get; set; }
  }
}