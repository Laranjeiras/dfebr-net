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
    public class InfMunCarrega
    {
        /// <summary>
        /// Código do Município de Carregamento 
        /// </summary>
        [XmlElement(ElementName = "cMunCarrega")]
        public string CMunCarrega { get; set; }

        /// <summary>
        /// Nome do Município de Carregamento 
        /// </summary>
        [XmlElement(ElementName = "xMunCarrega")]
        public string XMunCarrega { get; set; }
    }
}
