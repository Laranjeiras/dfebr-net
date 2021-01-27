// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using System.Collections.Generic;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    /// <summary>
    /// Informações dos Documentos fiscais vinculados ao manifesto
    /// </summary>
    public class InfDoc
    {
        /// <summary>
        /// Informações dos Municípios de descarregamento
        /// </summary>
        [XmlElement(ElementName = "infMunDescarga")]
        public List<InfMunDescarga> InfMunDescarga { get; set; }
    }
}
