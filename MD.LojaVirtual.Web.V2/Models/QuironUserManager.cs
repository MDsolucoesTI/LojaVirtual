//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using MD.LojaVirtual.Dominio.Entidades;
using MD.LojaVirtual.Dominio.Repositorio;

namespace MD.LojaVirtual.Web.V2.Models
{
  public class MDUserManager : UserManager<Cliente>
  {
    public MDUserManager(IUserStore<Cliente> store) : base(store) { }

    public static MDUserManager Create(IdentityFactoryOptions<MDUserManager> options, IOwinContext context)
    {
      var userManager = new MDUserManager(new UserStore<Cliente>(new EfDbContext()));

      return userManager;
    }
  }
}