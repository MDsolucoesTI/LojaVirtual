//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Web.Mvc;
using MD.LojaVirtual.Dominio.Entidades;

namespace MD.LojaVirtual.Web.Infraestrutura
{
  // IModelBinder interface define o método: BindModel
  public class CarrinhoModelBinder : IModelBinder
  {
    private const string SessionKey = "Carrinho";
    public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    {
      //Obtenho o carrinho da sessão
      Carrinho carrinho = null;
      if (controllerContext.HttpContext.Session != null)
      {
        carrinho = (Carrinho)controllerContext.HttpContext.Session[SessionKey];
      }
      // Crio o carrinho se não tenho a sessao
      if (carrinho == null)
      {
        carrinho = new Carrinho();
        if (controllerContext.HttpContext.Session != null)
        {
          controllerContext.HttpContext.Session[SessionKey] = carrinho;
        }
      }
      // Returno o carrinho
      return carrinho;
    }
  }
}
