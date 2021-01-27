// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autor: 
// Alexandre Laranjeiras (laranja22@hotmail.com)
// Data Criação: 27/10/2020
// Todos os direitos reservados
// =============================================================

namespace DFeBR.EmissorNFe.Dominio.ManifestoDocumento.Informacoes
{
    public class InfCIOT
    {
        /// <summary>
        /// Código Identificador da Operação de Transporte
        /// </summary>
        public string CIOT { get; set; }

        /// <summary>
        /// Número do CPF responsável pela geração do CIOT
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Número do CNPJ responsável pela geração do CIOT
        /// </summary>
        public string CNPJ { get; set; }
    }
}