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
using System.Web.Mvc;
using MD.LojaVirtual.Dominio.Dto;
using MD.LojaVirtual.Dominio.Entidades;

namespace MD.LojaVirtual.Web.V2.Models
{
  public class DetalhesProdutoViewModel
  {
    public MDProduto Produto { get; set; }
    public IEnumerable<Cor> Cores { get; set; }
    public IEnumerable<Tamanho> Tamanhos { get; set; }
    public BreadCrumbDto Breadcrumb { get; set; }
    public SelectList CoresList { get; set; }
    public SelectList TamanhoList { get; set; }
  }
}