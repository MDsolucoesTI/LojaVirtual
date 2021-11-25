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
    public class ItemPagSeguro
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "amount")]
        public decimal Amount { get; set; }
        [XmlElement(ElementName = "quantity")]
        public int Quantity { get; set; }
        [XmlElement(ElementName = "weight")]
        public int Weight { get; set; }

        private decimal cost;
        [XmlElement(ElementName = "shippingCost")]
        public string ShippingCost
        {
            get { return cost.ToString("n2"); }
            set { cost = decimal.Parse(value); }
        }
    }
}