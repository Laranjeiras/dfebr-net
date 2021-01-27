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
    public class InfContratante
    {
        [XmlElement(ElementName = "xNome")]
        public string XNome { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        /// <summary>
        /// Identificador do responsável pelo pgto em caso de ser estrangeiro
        /// </summary>
        [XmlElement(ElementName = "idEstrangeiro")]
        public string IdEstrangeiro { get; set; }
    }
}