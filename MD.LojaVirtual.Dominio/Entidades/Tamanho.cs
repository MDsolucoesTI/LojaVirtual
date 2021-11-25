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
  public class Tamanho
  {
    [Key]
    public int TamanhoId { get; set; }
    public string TamanhoCodigo { get; set; }
    public string TamanhoDescricaoResumida { get; set; }
    public string TamanhoDescricao { get; set; }

  }
}
