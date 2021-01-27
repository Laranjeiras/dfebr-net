// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using DFeBR.EmissorNFe.Utilidade.Tipos.MDFe;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    public class InfModal
    {
        public InfModal()
        {
            VersaoModal = VersaoModalMDFe.Versao300;
        }

        [XmlAttribute(AttributeName = "versaoModal")]
        public VersaoModalMDFe VersaoModal { get; set; }

        [XmlElement("rodo", typeof(Rodoviario), Namespace = "http://www.portalfiscal.inf.br/mdfe")]
        [XmlElement("aereo", typeof(Aereo), Namespace = "http://www.portalfiscal.inf.br/mdfe")]
        [XmlElement("aquav", typeof(Aquaviario), Namespace = "http://www.portalfiscal.inf.br/mdfe")]
        [XmlElement("ferrov", typeof(Ferroviario), Namespace = "http://www.portalfiscal.inf.br/mdfe")]
        public Modal Modal { get; set; }
    }
}
