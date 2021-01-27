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
    public class Dispositivo
    {       
        /// <summary>
        /// CNPJ da empresa fornecedora do ValePedágio
        /// </summary>
        [XmlElement(ElementName = "CNPJForn")]
        public string CNPJForn { get; set; }

        /// <summary>
        /// CNPJ do responsável pelo pagamento do Vale-Pedágio
        /// </summary>
        [XmlElement(ElementName = "CNPJPg")]
        public string CNPJPg { get; set; }

        /// <summary>
        /// CNPJ do responsável pelo pagamento do Vale-Pedágio
        /// </summary>
        public string CPFPg { get; set; }

        /// <summary>
        /// Número do comprovante de compra 
        /// </summary>
        [XmlElement(ElementName = "nCompra")]
        public string NCompra { get; set; }

        private decimal _vValePed;

        /// <summary>
        /// Valor do Vale-Pedagio 
        /// </summary>
        [XmlElement(ElementName = "vValePed")]
        public decimal VValePed
        {
            get { return Math.Round(_vValePed, 2); }
            set { _vValePed = value; }
        }
    }
}