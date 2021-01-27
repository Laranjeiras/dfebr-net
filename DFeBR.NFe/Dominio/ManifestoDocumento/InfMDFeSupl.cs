// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento
{
    public class InfMDFeSupl
    {
        /// <summary>
        /// Texto com o QR-Code para consulta do MDF-e
        /// </summary>
        [XmlElement(ElementName = "qrCodMDFe")]
        public string QrCodMDFe { get; set; }
    }
}
