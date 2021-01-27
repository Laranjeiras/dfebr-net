
namespace DFeBR.EmissorNFe.Dominio.Assinatura
{
    public class KeyInfo
    {
        public KeyInfo()
        {
            X509Data = new X509Data();
        }

        public X509Data X509Data { get; set; }
    }
}