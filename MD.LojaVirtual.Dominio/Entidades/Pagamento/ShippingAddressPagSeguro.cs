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
  public class ShippingAddressPagSeguro
  {
    [XmlElement(ElementName = "street")]
    public string Street { get; set; }
    [XmlElement(ElementName = "number")]
    public string Number { get; set; }
    [XmlElement(ElementName = "complement")]
    public string Complement { get; set; }
    [XmlElement(ElementName = "district")]
    public string District { get; set; }
    [XmlElement(ElementName = "city")]
    public string City { get; set; }
    [XmlElement(ElementName = "state")]
    public string State { get; set; }
    [XmlElement(ElementName = "country")]
    public string Country { get { return "BRA"; } set { } }
    [XmlElement(ElementName = "postalCode")]
    public string PostalCode { get; set; }
  }
}