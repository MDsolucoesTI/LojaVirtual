//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.ComponentModel.DataAnnotations;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class Cor
  {
    [Key]
    public int CorId { get; set; }
    public string CorDescricao { get; set; }
    public string CorCodigo { get; set; }
    public string Tamanho { get; set; }

  }
}
