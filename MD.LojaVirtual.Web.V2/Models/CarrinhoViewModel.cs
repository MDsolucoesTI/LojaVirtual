//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using MD.LojaVirtual.Dominio.Entidades;

namespace MD.LojaVirtual.Web.V2.Models
{
  public class CarrinhoViewModel
  {
    public Carrinho Carrinho { get; set; }
    public string ReturnUrl { get; set; }
  }
}