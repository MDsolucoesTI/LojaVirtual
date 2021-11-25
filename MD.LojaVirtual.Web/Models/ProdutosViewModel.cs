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

namespace MD.LojaVirtual.Web.Models
{
  public class ProdutosViewModel
  {
    public List<Produto> Produtos { get; set; }
    //public Paginacao Paginacao { get; set; }
    public string CategoriaAtual { get; set; }
  }
}