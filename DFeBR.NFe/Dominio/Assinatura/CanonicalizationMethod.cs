using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.Assinatura
{
    public class CanonicalizationMethod
    {
        [XmlAttribute]
        public string Algorithm { get; set; }
    }
}