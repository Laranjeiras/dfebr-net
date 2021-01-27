using DFeBR.EmissorNFe.Dominio.ManifestoDocumento;
using DFeBR.EmissorNFe.Utilidade;
using System.ComponentModel;
using Xunit;

namespace UnitTest.MDFe
{

    public class XmlMDFe
    {
        [Fact]
        [Description("Ler Arquivo XML")]
        public void CarregarMDFe()
        {
            var objeto = Utils.ArquivoXmlParaClasse<MDFeProc>(@"caminhoDoArquivo");
            Assert.NotNull(objeto);
        }
    }
}
