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
  public class MDProdutosRepositorio
  {

    private readonly EfDbContext _context = new EfDbContext();

    public IEnumerable<MDProduto> Produtos
    {
      get { return _context.MDProdutos; }
    }

    public MDProduto ObterProduto(string codigo, string corCodigo, string tamanhoCodigo)
    {
      return _context.MDProdutos.Single(p => p.ProdutoModeloCodigo == codigo
              && p.CorCodigo == corCodigo && p.TamanhoCodigo == tamanhoCodigo);
    }

    //Salvar Produto - Alterar Produto
    public void Salvar(MDProduto produto)
    {
      if (produto.ProdutoId == 0)
      {
        //Salvado
        _context.MDProdutos.Add(produto);
      }
      else
      {
        //Alteração
        _context.Entry(produto).State = System.Data.Entity.EntityState.Modified;
      }

      _context.SaveChanges();
    }

    //Excluir
    public MDProduto Excluir(int produtoId)
    {

      MDProduto prod = _context.MDProdutos.Find(produtoId);

      if (prod != null)
      {
        _context.MDProdutos.Remove(prod);
        _context.SaveChanges();
      }
      return prod;
    }
  }
}
