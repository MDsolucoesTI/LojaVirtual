//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using MD.LojaVirtual.Dominio.Entidades.Vitrine;

namespace MD.LojaVirtual.Web.V2.Models
{
  public class ProdutosViewModel
  {
    public List<ProdutoVitrine> Produtos { get; set; }

    public string Titulo { get; set; }
  }
}