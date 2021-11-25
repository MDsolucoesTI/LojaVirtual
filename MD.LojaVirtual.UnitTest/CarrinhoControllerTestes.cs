//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MD.LojaVirtual.Dominio.Entidades;
using MD.LojaVirtual.Web.Controllers;
using MD.LojaVirtual.Web.Models;

namespace MD.LojaVirtual.UnitTest
{
  [TestClass]
  public class CarrinhoControllerTestes
  {
    [TestMethod]
    public void AdicionarItemAoCarrinho()
    {

      Produto produto1 = new Produto
      {
        ProdutoId = 1,
        Nome = "Teste1"
      };

      Produto produto2 = new Produto
      {
        ProdutoId = 2,
        Nome = "Teste2"
      };

      Carrinho carrinho = new Carrinho();
      carrinho.AdicionarItem(produto1, 3);
      carrinho.AdicionarItem(produto2, 4);
      CarrinhoController controller = new CarrinhoController();
      Assert.AreEqual(carrinho.ItensCarrinho.Count(), 2);
      Assert.AreEqual(carrinho.ItensCarrinho.ToArray()[0].Produto.ProdutoId, 1);
    }

    [TestMethod]
    public void Adiciono_Produto_No_Carrinho_Volta_Para_A_Categoria()
    {
      Carrinho carrinho = new Carrinho();
      CarrinhoController controller = new CarrinhoController();
    }

    [TestMethod]
    public void Posso_Ver_O_Conteudo_Do_Carrinho()
    {
      Carrinho carrinho = new Carrinho();
      CarrinhoController controller = new CarrinhoController();
      CarrinhoViewModel resultado = (CarrinhoViewModel)controller.Index(carrinho, "minhaUrl").ViewData.Model;
      Assert.AreSame(resultado.Carrinho, carrinho);
      Assert.AreEqual(resultado.ReturnUrl, "minhaUrl");
    }
  }
}
