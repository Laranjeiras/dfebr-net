// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using System;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    /// <summary>
    /// Autorizados para download do XML
    /// </summary>
    public class AutXML
    {
        /// <summary>
        /// CNPJ do autorizado 
        /// </summary>
        [XmlElement(ElementName = "CNPJ")]
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do autorizado
        /// </summary>
        [XmlElement(ElementName = "CPF")]
        public string CPF { get; set; }
    }
}
