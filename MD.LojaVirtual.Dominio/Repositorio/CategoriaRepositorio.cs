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
  public class CategoriaRepositorio
  {
    private readonly EfDbContext _context = new EfDbContext();

    public IEnumerable<Categoria> ObterCategorias()
    {
      return _context.Categorias.OrderBy(c => c.CategoriaDescricao);
    }
  }
}
