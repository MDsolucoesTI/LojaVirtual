//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.ComponentModel.DataAnnotations;

namespace MD.LojaVirtual.Web.V2.Models
{
  public class LoginViewModel
  {
    [Required]
    [Display(Name = "Nome de usuário")]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Senha")]
    public string Password { get; set; }

    [Display(Name = "Lembre-me")]
    public bool RememberMe { get; set; }
  }
}