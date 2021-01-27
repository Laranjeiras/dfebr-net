// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using DFeBR.EmissorNFe.Utilidade.Tipos.MDFe;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    public class InfUnidTranspVazia
    {
        [XmlElement(ElementName = "idUnidTranspVazia")]
        public string IdUnidTranspVazia { get; set; }

        [XmlElement(ElementName = "tpUnidTranspVazia")]
        public TipoUnidadeTranspVazia TpUnidTranspVazia { get; set; }
    }
}