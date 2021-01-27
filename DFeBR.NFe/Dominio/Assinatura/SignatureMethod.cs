
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.Assinatura
{
    public class SignatureMethod
    {
        [XmlAttribute]
        public string Algorithm { get; set; }
    }
}