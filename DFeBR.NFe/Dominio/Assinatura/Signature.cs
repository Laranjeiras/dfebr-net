﻿
using System.Xml.Serialization;

namespace DFeBR.EmissorNFe.Dominio.Assinatura
{
    [XmlRoot(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Signature
    {
        public SignedInfo SignedInfo { get; set; }

        public string SignatureValue { get; set; }

        public KeyInfo KeyInfo { get; set; }
    }
}