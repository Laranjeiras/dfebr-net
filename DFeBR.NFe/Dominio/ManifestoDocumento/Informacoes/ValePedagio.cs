// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

using System.Collections.Generic;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    public class ValePedagio
    {
        /// <summary>
        /// Informações dos dispositivos do Vale Pedágio
        /// </summary>
        [XmlElement(ElementName = "disp")]
        public List<Dispositivo> Disp { get; set; }
    }
}