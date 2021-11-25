//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Linq;

namespace MD.LojaVirtual.Dominio.Entidades
{
  public class Carrinho
  {

    private readonly List<ItemCarrinho> _itemCarrinho = new List<ItemCarrinho>();

    //Adicionar
    public void AdicionarItem(MDProduto produto, int quantidade)
    {
      ItemCarrinho item = _itemCarrinho.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);

      if (item == null)
      {
        _itemCarrinho.Add(new ItemCarrinho
        {
          Produto = produto,
          Quantidade = quantidade
        });
      }
      else
      {
        item.Quantidade = quantidade;
      }
    }

    // Remover item
    public void RemevorItem(MDProduto produto)
    {
      _itemCarrinho.RemoveAll(l => l.Produto.ProdutoId == produto.ProdutoId);
    }

    //Obter o valor total
    public decimal ObterValorTotal()
    {
      return _itemCarrinho.Sum(e => e.Produto.Preco * e.Quantidade);
    }

    //Limpar carrinho
    public void LimparCarrinho()
    {
      _itemCarrinho.Clear();
    }

    //Itens carrinho
    public IEnumerable<ItemCarrinho> ItensCarrinho
    {
      get { return _itemCarrinho; }
    }
  }

  public class ItemCarrinho
  {
    public MDProduto Produto { get; set; }

    public int Quantidade { get; set; }
  }
}
