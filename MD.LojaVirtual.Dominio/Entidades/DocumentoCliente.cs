//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class DocumentoCliente
  {
    [Key, ForeignKey("Id")]
    public virtual Cliente Cliente { get; set; }

    public string Id { get; set; }
    public TipoDocumento Tipo { get; set; }
    public long Valor { get; set; }
    public DateTime DtNasc { get; set; }
  }

  public enum TipoDocumento
  {
    CPF
  }
}
