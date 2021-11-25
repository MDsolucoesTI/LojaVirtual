//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class MDProduto
  {
    [Key]
    public int ProdutoId { get; set; }

    public string ProdutoCodigo { get; set; }

    public string ProdutoModeloCodigo { get; set; }

    public string CorCodigo { get; set; }

    public string TamanhoCodigo { get; set; }

    public decimal Preco { get; set; }

    public string ProdutoDescricao { get; set; }

    public string ProdutoDescricaoResumida { get; set; }

    public string MarcaDescricao { get; set; }

    public string ModeloDescricao { get; set; }

    public string UnidadeVenda { get; set; }

    public string Imagem
    {
      get { return ProdutoCodigo.Substring(0, 8) + ".jpg"; }

    }

    public virtual ICollection<ProdutoPedido> ProdutosPedido { get; set; }
  }
}

