//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.LojaVirtual.Dominio.Entidades;

namespace MD.LojaVirtual.Dominio.Repositorio
{

  public class AdministradoresRepositorio
  {
    private readonly EfDbContext _context = new EfDbContext();

    public Administrador ObterAdministrador(Administrador administrador)
    {
      return _context.Administradores.FirstOrDefault(a => a.Login == administrador.Login);
    }
  }
}
