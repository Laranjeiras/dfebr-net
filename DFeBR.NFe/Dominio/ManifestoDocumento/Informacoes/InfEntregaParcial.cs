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
    /// <summary>
    /// Grupo de informações da Entrega Parcial (Corte de Voo) 
    /// </summary>
    public class InfEntregaParcial
    {
        /// <summary>
        /// Quantidade total de volumes
        /// </summary>
        [XmlElement(ElementName = "qtdTotal")]
        public decimal QtdTotal { get; set; }

        /// <summary>
        /// Quantidade de volumes enviados no MDF-e
        /// </summary>
        [XmlElement(ElementName = "qtdParcial")]
        public decimal QtdParcial { get; set; }
    }
}
