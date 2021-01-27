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
    public class InfTerminaisDescarregamento
    {
        /// <summary>
        /// Código do Terminal de Descarregamento
        /// </summary>
        [XmlElement(ElementName = "cTermDescarreg")]
        public string CTermDescarreg { get; set; }

        /// <summary>
        /// Nome do Terminal de Descarregamento
        /// </summary>
        [XmlElement(ElementName = "xTermDescarreg")]
        public string XTermDescarreg { get; set; }
    }
}
