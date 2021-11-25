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
using MD.LojaVirtual.Dominio.Entidades.Vitrine;

namespace MD.LojaVirtual.Dominio.Repositorio
{
  public class ProdutoModeloRepositorio
  {
    private readonly EfDbContext _context = new EfDbContext();

    /// <summary>
    /// Obter produtos da View SQL Produto Vitrine
    /// </summary>
    /// <param name="categoria"></param>
    /// <param name="genero"></param>
    /// <param name="grupo"></param>
    /// <param name="subgrupo"></param>
    /// <param name="linha"></param>
    /// <param name="marca"></param>
    /// <param name="modalidade"></param>
    /// <returns></returns>
    public List<ProdutoVitrine> ObterProdutosVitrine(string categoria = null, string genero = null
       , string grupo = null, string subgrupo = null, string linha = null,
        string marca = null, string modalidade = null, string busca = null)
    {
      var query = from p in _context.ProdutoVitrine select p;

      if (!string.IsNullOrEmpty(categoria))
        query = query.Where(p => p.CategoriaCodigo == categoria);

      if (!string.IsNullOrEmpty(genero))
        query = query.Where(p => p.GeneroCodigo == genero);

      if (!string.IsNullOrEmpty(grupo))
        query = query.Where(p => p.GrupoCodigo == grupo);

      if (!string.IsNullOrEmpty(subgrupo))
        query = query.Where(p => p.SubGrupoCodigo == subgrupo);

      if (!string.IsNullOrEmpty(linha))
        query = query.Where(p => p.LinhaCodigo == linha);

      if (!string.IsNullOrEmpty(marca))
        query = query.Where(p => p.MarcaCodigo == marca);

      if (!string.IsNullOrEmpty(modalidade))
        query = query.Where(p => p.ModalidadeCodigo == modalidade);

      if (!string.IsNullOrEmpty(busca))
        query = query.Where(p => p.ProdutoDescricao.Contains(busca)); //%proteina%

      query = query.OrderBy(p => Guid.NewGuid());
      query = query.Take(40);

      return query.ToList();
    }
  }
}
