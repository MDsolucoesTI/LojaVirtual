//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel.DataAnnotations;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class Administrador
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Digite o login")]
    [Display(Name = "Login:")]
    public string Login { get; set; }

    [Required(ErrorMessage = "Digite a senha:")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    public DateTime UltimoAcesso { get; set; }

  }
}
