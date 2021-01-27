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
    public class InfTerminaisCarregamento
    {
        /// <summary>
        /// Código do Terminal de Carregamento 
        /// </summary>
        [XmlElement(ElementName = "cTermCarreg")]
        public string CTermCarreg { get; set; }

        /// <summary>
        /// Nome do Terminal de Carregamento 
        /// </summary>
        [XmlElement(ElementName = "xTermCarreg")]
        public string XTermCarreg { get; set; }
    }
}