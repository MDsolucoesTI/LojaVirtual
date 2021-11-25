//////////////////////////////////////////////////////////////////////////
// Criacao...........: 06/2014
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System.Xml.Serialization;

namespace MD.LojaVirtual.Dominio.Entidades.Pagamento
{
  public class ShippingPagSeguro
  {
    [XmlElement(ElementName = "address")]
    public ShippingAddressPagSeguro Address { get; set; }
    [XmlElement(ElementName = "type")]
    public int Type { get; set; } // 1- PAC, 2 - SEDEX, 3 - Não especificado

    private decimal cost;
    [XmlElement(ElementName = "cost")]
    public string Cost
    {
      get { return cost.ToString("n2"); }
      set { cost = decimal.Parse(value); }
    }
  }
}