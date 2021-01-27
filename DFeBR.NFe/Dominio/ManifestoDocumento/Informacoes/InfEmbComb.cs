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
    public class InfEmbComb
    {
        /// <summary>
        /// Código da embarcação do comboio 
        /// </summary>
        [XmlElement(ElementName = "cEmbComb")]
        public string CEmbComb { get; set; }

        /// <summary>
        /// Identificador da Balsa 
        /// </summary>
        [XmlElement(ElementName = "xBalsa")]
        public string XBalsa { get; set; }
    }
}