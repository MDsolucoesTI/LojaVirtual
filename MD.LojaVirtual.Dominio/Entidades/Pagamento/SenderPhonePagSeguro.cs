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
  public class SenderPhonePagSeguro
  {
    [XmlElement(ElementName = "areaCode")]
    public string AreaCode { get; set; }
    [XmlElement(ElementName = "number")]
    public string Number { get; set; }
  }
}