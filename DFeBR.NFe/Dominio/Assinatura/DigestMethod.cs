using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.Assinatura
{
    public class DigestMethod
    {
        [XmlAttribute]
        public string Algorithm { get; set; }
    }
}