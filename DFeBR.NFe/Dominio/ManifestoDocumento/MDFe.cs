// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using DFeBR.EmissorNFe.Dominio.Assinatura;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento
{
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/mdfe", ElementName = "MDFe")]
    public class MDFe
    {
        public MDFe()
        {
            InfMDFe = new InfMDFe();
        }

        [XmlElement(ElementName = "infMDFe")]
        public InfMDFe InfMDFe { get; set; }

        [XmlElement(ElementName = "infMDFeSupl")]
        public InfMDFeSupl InfMDFeSupl { get; set; }

        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature { get; set; }
    }
}
