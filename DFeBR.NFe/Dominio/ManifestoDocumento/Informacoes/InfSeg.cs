﻿// =============================================================
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
    /// Informações da seguradora 
    /// </summary>
    public class InfSeg
    {
        /// <summary>
        /// Nome da Seguradora
        /// </summary>
        [XmlElement(ElementName = "xSeg")]
        public string XSeg { get; set; }

        /// <summary>
        /// Número do CNPJ da seguradora
        /// </summary>
        [XmlElement(ElementName = "CNPJ")]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número da Apólice 
        /// </summary>
        [XmlElement(ElementName = "nApol")]
        public string NApol { get; set; }

        /// <summary>
        /// Número da Averbação
        /// </summary>
        [XmlElement(ElementName = "nAver")]
        public string NAver { get; set; }
    }
}
