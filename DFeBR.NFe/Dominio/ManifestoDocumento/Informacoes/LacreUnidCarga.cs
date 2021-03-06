﻿// =============================================================
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
    public class LacreUnidCarga
    {
        /// <summary>
        /// 7 - Número do lacre
        /// </summary>
        [XmlElement(ElementName = "nLacre")]
        public string NLacre { get; set; }
    }
}
