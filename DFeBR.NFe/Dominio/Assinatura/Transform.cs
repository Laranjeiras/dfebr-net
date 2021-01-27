
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.Assinatura
{
    public class Transform
    {
        [XmlAttribute]
        public string Algorithm { get; set; }
    }
}