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
    public class SenderDocumentPagSeguro
    {
        [XmlElement(ElementName = "type")]
        public string Type { get { return "CPF"; } set { } }
        [XmlElement(ElementName = "value")]
        public string Value { get; set; }
    }
}