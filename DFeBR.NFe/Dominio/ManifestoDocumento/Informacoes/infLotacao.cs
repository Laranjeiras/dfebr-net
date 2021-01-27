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
    public class InfLotacao
    {
        [XmlElement(ElementName = "infLocalCarrega")]
        public InfLocalCarregamento InfLocalCarrega { get; set; }

        [XmlElement(ElementName = "infLocalDescarrega")]
        public InfLocalDescarregamento InfLocalDescarrega { get; set; }
    }
}
