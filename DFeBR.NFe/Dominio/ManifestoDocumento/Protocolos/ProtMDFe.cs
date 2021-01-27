// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Protocolos
{
    public class ProtMDFe
    {
        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }

        [XmlElement(ElementName = "infProt")]
        public InfProt InfProt { get; set; }
    }
}