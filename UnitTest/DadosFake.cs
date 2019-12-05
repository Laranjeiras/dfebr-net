using DFeBR.EmissorNFe.Builders.Cobranca;
using DFeBR.EmissorNFe.Builders.Destinatario;
using DFeBR.EmissorNFe.Builders.Detalhe;
using DFeBR.EmissorNFe.Builders.Identificacao;
using DFeBR.EmissorNFe.Builders.Pagamento;
using DFeBR.EmissorNFe.Builders.ResponsavelTecnico;
using DFeBR.EmissorNFe.Builders.Total;
using DFeBR.EmissorNFe.Builders.Transporte;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Configurar;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Total;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    internal class DadosFake
    {
        internal static EmissorServicoConfig GetConfig_Fake()
        {
            var config = new EmissorServicoConfig(
                DFeBR.EmissorNFe.Utilidade.Tipos.VersaoServico.Ve400,
                DFeBR.EmissorNFe.Utilidade.Tipos.Estado.Rj,
                DFeBR.EmissorNFe.Utilidade.Tipos.TipoAmbiente.Homologacao,
                DFeBR.EmissorNFe.Utilidade.Tipos.IndicadorSincronizacao.Sincrono
                );
            config.ConfiguraEmitente(
                "11.367.874/0001-06",
                null,
                "COMERCIAL RIO LUBRIFICANTES LTDA ME",
                null,
                "79460508",
                null,
                null,
                "47.32-6-00",
                DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Emitente.CRT.SimplesNacional,
                "RUA CONDE DE PORTO ALEGRE",
                "15",
                "Sala 606",
                "CENTRO",
                3301702,
                "DUQUE DE CAXIAS",
                "RJ",
                "25070350",
                null
            );

            config.ConfiguraCertificadoA1Repositorio("serial do certificado");
            config.ConfiguraCSC("CscID", "CscToken");
            config.ConfiguraArquivoRetorno(true, @"C:\XML\");

            return config;
        }

        internal static DetalheNFe40 GetDetalheNDe40_Fake() 
        {
            var detalhe = new DetalheNFe40(
                1,
                "15337",
                "7891150054646",
                "Desodorante Aerosol Rexona Men Impacto 90g",
                "33072010",
                "2002700",
                DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.indEscala.N,
                null,null,null,
                5102,
                "UND",
                1m,
                9.99m,
                9.99m,
                1m,
                9.99m,
                DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.IndicadorTotal.ValorDoItemCompoeTotalNF
            );
            //detalhe.SetICMS20(
            //new DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual.Tipos.OrigemMercadoria
            //);
            //detalhe.SetIPI(...);
            //detalhe.SetPISOutr(...);
            //detalhe.SetII(...);
            //detalhe.SetCOFINSOutr(...);

            return detalhe;

        }

        internal static TransporteNFe40 GetTransporte_Fake()
        {
            var transp = new TransporteNFe40(
                DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Transporte.ModalidadeFrete.mfProprioContaRemente,
                null, null
            );
            //transp.SetTransportadora(....);
            //transp.AddVolume(.....);
            return transp;
        }

        internal static CobrancaNFe40 GetCobranca_Fake()
        {
            var cobr = new CobrancaNFe40("1",9.99m,0, 9.99m);
            cobr.AddDuplicata("1", DateTime.Now.AddDays(10), 9.99m);
            return cobr;
        }

        internal static PagamentoNFe40 GetPagamento_Fake()
        {
            var pag = new PagamentoNFe40(
                DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Pagamento.FormaPagamento.fpDinheiro, 9.99m, null
                );
            //pag.AdicionaDetalhe(DFeBR.EmissorNFe.Utilidade.Tipos.IndicadorPagamentoDetalhePagamento.IpDetPgVista, DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Pagamento.FormaPagamento.fpDinheiro,9.99m);
            //pag.AdicionaDetalheCartao(.....);
            return pag;
        }

        internal static IdentificacaoNFe40 GetIdentificacaoNFe4_Fake() 
        {

            var config = new DFeBR.EmissorNFe.Configurar(DadosFake.GetConfig_Fake());

            return new IdentificacaoNFe40(
                config,
                "1",
                "VENDA",
                DFeBR.EmissorNFe.Utilidade.Tipos.ModeloDocumento.NFe,
                1,
                1,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DFeBR.EmissorNFe.Utilidade.Tipos.TipoNFe.Saida,
                DFeBR.EmissorNFe.Utilidade.Tipos.DestinoOperacao.Interna,
                DFeBR.EmissorNFe.Utilidade.Tipos.TipoImpressao.NormalRetrato,
                DFeBR.EmissorNFe.Utilidade.Tipos.TipoEmissao.Normal,
                DFeBR.EmissorNFe.Utilidade.Tipos.FinalidadeNFe.FnNormal,
                DFeBR.EmissorNFe.Utilidade.Tipos.ConsumidorFinal.Nao,
                DFeBR.EmissorNFe.Utilidade.Tipos.PresencaComprador.PcNao,
                "4,00",
                DateTime.Now,
                "Justificativa"
                );

        }

        internal static DestinatarioNFe40 GetDestinatario_Fake() {
            return new DestinatarioNFe40(
                "11.367.874/0001-06",
                null,
                null,
                "COMERCIAL RIO LUBRIFICANTES LTDA ME",
                DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Destinatario.indIEDest.ContribuinteICMS,
                "79460508",
                null,
                null,
                "laranja22@hotmail.com"
                


            );
        }

        internal static TotalNFe40 GetTotalNFe40() 
        {
            var icmsTot = new ICMSTot
            {
                vBC = 0,
                vICMS = 0,
                vICMSDeson = 0,
                vFCPUFDest = 0,
                vICMSUFDest = 0,
                vICMSUFRemet = 0,
                vFCP = 0,
                vBCST = 0,
                vST = 0,
                vFCPST = 0,
                vFCPSTRet = 0,
                vProd = 9.99m,
                vFrete = 0,
                vSeg = 0,
                vDesc = 0,
                vII = 0,
                vIPI = 0,
                vIPIDevol = 0,
                vPIS = 0,
                vCOFINS = 0,
                vOutro = 0,
                vNF = 9.99m,
                vTotTrib = 0
            };
            return new TotalNFe40(icmsTot);
        }

        internal static ResponsavelTecNFe40 GetResponsavelTec() {
            return new ResponsavelTecNFe40(
                "05.230.584/0001-05",
                "Alexandre",
                "laranja22@otmail.com",
                "21971614935",
                null
            );
        }
    }
}
