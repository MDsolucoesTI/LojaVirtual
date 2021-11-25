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

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class Estoque
  {
    [Key]
    public int EstoqueId { get; set; }

    public string ProdutoCodigo { get; set; }
    public int Quantidade { get; set; }

    public DateTime DataAtualizacao { get; set; }
  }
}
