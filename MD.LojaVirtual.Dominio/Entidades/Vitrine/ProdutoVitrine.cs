//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.LojaVirtual.Dominio.Entidades.Vitrine
{
  public class ProdutoVitrine
  {
    [Key]
    public string ProdutoModeloCor { get; set; }
    public string ProdutoDescricao { get; set; }
    public string MarcaDescricao { get; set; }
    public decimal Preco { get; set; }
    public string GrupoCodigo { get; set; }
    public string SubGrupoCodigo { get; set; }
    public string CategoriaCodigo { get; set; }
    public string MarcaCodigo { get; set; }
    public string GeneroCodigo { get; set; }
    public string FaixaEtariaCodigo { get; set; }
    public string ModalidadeCodigo { get; set; }
    public string LinhaCodigo { get; set; }

    public string Imagem
    {
      get { return ProdutoModeloCor + ".jpg"; }

    }

    public decimal Parcela
    {
      get { return Math.Round(Preco / 3, 2); }

    }

  }
}
