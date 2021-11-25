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
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class ProdutoPedido
  {
    [Key]
    public int Id { get; set; }

    public int PedidoId { get; set; }

    [ForeignKey("PedidoId")]
    public virtual Pedido Pedido { get; set; }

    public int ProdutoId { get; set; }

    [ForeignKey("ProdutoId")]
    public virtual MDProduto Produto { get; set; }

    [Required]
    public int Quantidade { get; set; }
  }
}
