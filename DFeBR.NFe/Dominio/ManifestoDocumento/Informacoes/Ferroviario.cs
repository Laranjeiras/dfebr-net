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
    public class Ferroviario : Modal
    {
        /// <summary>
        /// Informações da composição do trem
        /// </summary>
        [XmlElement(ElementName = "trem")]
        public Trem Trem { get; set; }

        /// <summary>
        /// Informações dos Vagões
        /// </summary>
        [XmlElement(ElementName = "vag")]
        public List<Vagoes> Vag { get; set; }
    }
}