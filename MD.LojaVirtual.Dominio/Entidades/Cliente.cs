//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class Cliente : IdentityUser
  {
    [NotMapped]
    public string Senha { get; set; }

    [Required]
    public string NomeCompleto { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; }

    // Telefone
    [Required]
    public virtual TelefoneCliente Telefone { get; set; }

    // Documento
    [Required]
    public virtual DocumentoCliente Documento { get; set; }

    // Endereço
    [Required]
    public virtual EnderecoCliente Endereco { get; set; }
  }
}
