
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.Assinatura
{
    public class Reference
    {
        [XmlAttribute]
        public string URI { get; set; }

        public List<Transform> Transforms { get; set; }

        public DigestMethod DigestMethod { get; set; }

        public string DigestValue { get; set; }
    }
}