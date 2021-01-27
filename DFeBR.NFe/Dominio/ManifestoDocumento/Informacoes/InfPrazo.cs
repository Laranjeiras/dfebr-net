// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using DFeBR.EmissorNFe.Utilidade;
using System;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    public class InfPrazo
    {
        [XmlIgnore]
        public short NParcela { get; set; }

        [XmlElement("nParcela")]
        public string NParcelaProxy
        {
            get { return NParcela.ToString("D3"); }
            set { NParcela = short.Parse(value); }
        }

        [XmlIgnore]
        public DateTime DVenc { get; set; }

        [XmlElement("dVenc")]
        public string DVencProxy
        {
            get { return DVenc.ParaDataString(); }
            set { DVenc = DateTime.Parse(value); }
        }

        [XmlIgnore]
        public decimal VParcela { get; set; }

        [XmlElement("vParcela")]
        public decimal VParcelaProxy
        {
            get { return VParcela.Arredondar(2); }
            set { VParcela = value.Arredondar(2); }
        }
    }
}
