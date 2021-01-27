// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using DFeBR.EmissorNFe.Utilidade.Tipos.MDFe;
using System;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    public class InfUnidCargaVazia
    {
        /// <summary>
        /// Identificação da unidades de carga vazia
        /// </summary>
        [XmlElement(ElementName = "idUnidCargaVazia")]
        public string IdUnidCargaVazia { get; set; }

        /// <summary>
        /// Tipo da unidade de carga vazia 
        /// </summary>
        [XmlElement(ElementName = "tpUnidCargaVazia")]
        public TipoUnidCargaVazia TpUnidCargaVazia { get; set; }
    }
}
