// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    public class InfAdic
    {
        /// <summary>
        /// Informações adicionais de interesse do Fisco
        /// </summary>
        [XmlElement(ElementName = "infAdFisco")]
        public string InfAdFisco { get; set; }

        /// <summary>
        /// Informações complementares de interesse do Contribuinte
        /// </summary>
        [XmlElement(ElementName = "infCpl")]
        public string InfCpl { get; set; }
    }
}
