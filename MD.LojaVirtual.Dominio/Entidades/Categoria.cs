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
  public class Categoria
  {
    public int CategoriaId { get; set; }
    public string CategoriaCodigo { get; set; }
    public string CategoriaDescricao { get; set; }
  }
}
