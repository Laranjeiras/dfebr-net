// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using DFeBR.EmissorNFe.Utilidade;
using DFeBR.EmissorNFe.Utilidade.Tipos;
using System;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    public class InfPercurso
    {
        /// <summary>
        /// Sigla das Unidades da Federação do percurso do veículo.
        /// </summary>
        [XmlIgnore]
        public Estado UFPer { get; set; }

        [XmlElement(ElementName = "UFPer")]
        public string ProxyUFPer
        {
            get { return UFPer.ToString(); }
            set { UFPer = value.SiglaParaEstado(); }
        }
    }
}
