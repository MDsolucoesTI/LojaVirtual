//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using MD.LojaVirtual.Dominio.Entidades;

namespace MD.LojaVirtual.Web.V2.Models
{
  public class MDSignInManager : SignInManager<Cliente, string>
  {
    public MDSignInManager(MDUserManager userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager) { }

    public static MDSignInManager Create(IdentityFactoryOptions<MDSignInManager> option, IOwinContext context)
    {
      var manager = context.GetUserManager<MDUserManager>();
      var sign = new MDSignInManager(manager, context.Authentication);
      return sign;
    }
  }
}