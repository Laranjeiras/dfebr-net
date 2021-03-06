﻿// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autores: 
// Valnei Filho  e-mail: vmarinpietri@yahoo.com.br;
// Marco Polo  e-mail: marcopoloviana@hotmail.com
// Marcis Vinícius email: marcos8154@gmail.com
// Data Criação:26/03/2019
// Todos os direitos reservados
// 


using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Municipal;

namespace DFeBR.EmissorNFe.Builders.Detalhe
{
    public sealed class DetalheNFe40 : DetalheNFe
    {
        /// <summary>
        /// Detalhes da NFe v4.0 - CONSTRUTOR COMPLETO
        /// </summary>
        /// <param name="config"></param>
        /// <param name="nItem"></param>
        /// <param name="cProd"></param>
        /// <param name="cEan"></param>
        /// <param name="xProd"></param>
        /// <param name="NCM"></param>
        /// <param name="CEST"></param>
        /// <param name="indEscala"></param>
        /// <param name="CNPJFab"></param>
        /// <param name="cBenef"></param>
        /// <param name="EXTIPI"></param>
        /// <param name="CFOP"></param>
        /// <param name="uCom"></param>
        /// <param name="qCom"></param>
        /// <param name="vUnCom"></param>
        /// <param name="vProd"></param>
        /// <param name="uTrib"></param>
        /// <param name="vUnTrib"></param>
        /// <param name="vFrete"></param>
        /// <param name="vSeg"></param>
        /// <param name="vDesc"></param>
        /// <param name="vOutro"></param>
        /// <param name="indTot"></param>
        /// <param name="xPed"></param>
        /// <param name="nItemPed"></param>
        /// <param name="nFCI"></param>
        /// <param name="nRECOPI"></param>
        public DetalheNFe40(int nItem,
            string cProd, string cEan, string xProd, string NCM,
            string CEST, indEscala? indEscala, string CNPJFab,
            string cBenef, string EXTIPI, int CFOP,
            string uCom, decimal qCom, decimal vUnCom,
            decimal vProd, decimal uTrib, decimal vUnTrib,
            decimal? vFrete, decimal? vSeg,
            decimal? vDesc, decimal? vOutro, IndicadorTotal indTot,
            string xPed, int? nItemPed, string nFCI,
            string nRECOPI)
        {
            SetDetalhe(new det
            {
                nItem = nItem,
                prod = new prod
                {
                    cProd = cProd,
                    cEAN = cEan,
                    xProd = xProd,
                    NCM = NCM,
                    CEST = CEST,
                    indEscala = indEscala,
                    CNPJFab = CNPJFab,
                    cBenef = cBenef,
                    EXTIPI = EXTIPI,
                    CFOP = CFOP,
                    uCom = uCom,
                    vUnCom = vUnCom,
                    vFrete = vFrete,
                    vSeg = vSeg,
                    vDesc = vDesc,
                    indTot = indTot,
                    xPed = xPed,
                    nItemPed = nItemPed,
                    nFCI = nFCI,
                    nRECOPI = nRECOPI
                }
            });
        }

        /// <summary>
        /// Detalhes da NFe v4.0 - CONSTRUTOR BASICO
        /// </summary>
        /// <param name="config"></param>
        /// <param name="nItem"></param>
        /// <param name="cProd"></param>
        /// <param name="cEan"></param>
        /// <param name="xProd"></param>
        /// <param name="NCM"></param>
        /// <param name="CEST"></param>
        /// <param name="indEscala"></param>
        /// <param name="CNPJFab"></param>
        /// <param name="cBenef"></param>
        /// <param name="EXTIPI"></param>
        /// <param name="CFOP"></param>
        /// <param name="uCom"></param>
        /// <param name="qCom"></param>
        /// <param name="vUnCom"></param>
        /// <param name="vProd"></param>
        /// <param name="uTrib"></param>
        /// <param name="vUnTrib"></param>
        /// <param name="indTot"></param>
        public DetalheNFe40(int nItem,
            string cProd, string cEan, string xProd, string NCM,
            string CEST, indEscala? indEscala, string CNPJFab,
            string cBenef, string EXTIPI, int CFOP,
            string uCom, decimal qCom, decimal vUnCom,
            decimal vProd, decimal uTrib, decimal vUnTrib,
            IndicadorTotal indTot)
        {
            SetDetalhe(new det
            {
                nItem = nItem,
                prod = new prod
                {
                    cProd = cProd,
                    cEAN = cEan,
                    xProd = xProd,
                    NCM = NCM,
                    CEST = CEST,
                    indEscala = indEscala,
                    CNPJFab = CNPJFab,
                    cBenef = cBenef,
                    EXTIPI = EXTIPI,
                    CFOP = CFOP,
                    uCom = uCom,
                    vUnCom = vUnCom,
                    indTot = indTot
                }
            });
        }

        #region Identificacao ICMS
        public void SetICMS00(OrigemMercadoria orig,
              DeterminacaoBaseIcms modBC, decimal vBC, decimal pICMS,
              decimal vICMS, decimal? pFCP, decimal? vFCP)
        {
            InformarICMS(new ICMS00
            {
                orig = orig,
                CST = Csticms.Cst00,
                modBC = modBC,
                vBC = vBC,
                pICMS = pICMS,
                vICMS = vICMS,
                pFCP = pFCP,
                vFCP = vFCP
            });
        }

        public void SetICMS10(OrigemMercadoria orig,
            DeterminacaoBaseIcms modBC, decimal vBC, decimal pICMS,
            decimal vICMS, decimal? vBCFCP,
            decimal? pFCP, decimal? vFCP,
            DeterminacaoBaseIcmsSt modBCST,
            decimal? pMVAST, decimal? pRedBCST,
            decimal vBCST, decimal pICMSST,
            decimal vICMSST, decimal? vBCFCPST,
            decimal? pFCPST, decimal? vFCPST)
        {
            InformarICMS(new ICMS10
            {
                orig = orig,
                CST = Csticms.Cst10,
                modBC = modBC,
                vBC = vBC,
                pICMS = pICMS,
                vICMS = vICMS,
                vBCFCP = vBCFCP,
                pFCP = pFCP,
                vFCP = vFCP,
                modBCST = modBCST,
                pMVAST = pMVAST,
                pRedBCST = pRedBCST,
                vBCST = vBCST,
                pICMSST = pICMSST,
                vICMSST = vICMSST,
                vBCFCPST = vBCFCPST,
                pFCPST = pFCPST,
                vFCPST = vFCPST
            });
        }

        public void SetICMS20(OrigemMercadoria orig,
         DeterminacaoBaseIcms modBC, decimal vBC,
         decimal pICMS, decimal vICMS,
         decimal? vBCFCP, decimal? pFCP, decimal? vFCP,
         decimal? vICMSDeson, MotivoDesoneracaoIcms? motDesICMS)
        {
            InformarICMS(new ICMS20
            {
                orig = orig,
                CST = Csticms.Cst20,
                modBC = modBC,
                vBC = vBC,
                pICMS = pICMS,
                vICMS = vICMS,
                vBCFCP = vBCFCP,
                pFCP = pFCP,
                vFCP = vFCP,
                vICMSDeson = vICMSDeson,
                motDesICMS = motDesICMS
            });
        }

        public void SetICMS30(OrigemMercadoria orig,
         DeterminacaoBaseIcmsSt modBCST, decimal? pMVAST,
         decimal? pRedBCST, decimal vBCST,
         decimal pICMSST, decimal vICMSST,
         decimal? vBCFCPST, decimal? pFCPST,
         decimal? vFCPST, decimal? vICMSDeson,
         MotivoDesoneracaoIcms? motDesICMS)
        {
            InformarICMS(new ICMS30
            {
                CST = Csticms.Cst30,
                orig = orig,
                modBCST = modBCST,
                pMVAST = pMVAST,
                pRedBCST = pRedBCST,
                vBCST = vBCST,
                pICMSST = pICMSST,
                vICMSST = vICMSST,
                vBCFCPST = vBCFCPST,
                pFCPST = pFCPST,
                vFCPST = vFCPST,
                vICMSDeson = vICMSDeson,
                motDesICMS = motDesICMS
            });
        }

        public void SetICMS40(OrigemMercadoria orig,
            decimal? vICMSDeson, MotivoDesoneracaoIcms? motDesICMS)
        {
            InformarICMS(new ICMS40
            {
                CST = Csticms.Cst40,
                orig = orig,
                motDesICMS = motDesICMS
            });
        }

        public void SetICMS51(OrigemMercadoria orig,
            DeterminacaoBaseIcms? modBC, decimal? pRedBC,
            decimal? vBC, decimal? pICMS, decimal? vICMSOp,
            decimal? pDif, decimal? vICMSDif,
            decimal? vICMS, decimal? vBCFCP,
            decimal? pFCP, decimal? vFCP)
        {
            InformarICMS(new ICMS51
            {
                CST = Csticms.Cst51,
                orig = orig,
                modBC = modBC,
                pRedBC = pRedBC,
                vBC = vBC,
                pICMS = pICMS,
                vICMSOp = vICMSOp,
                pDif = pDif,
                vICMSDif = vICMSDif,
                vICMS = vICMS,
                vBCFCP = vBCFCP,
                pFCP = pFCP,
                vFCP = vFCP
            });
        }

        public void SetICMS60(OrigemMercadoria orig,
            decimal? vBCSTRet,
            decimal? pST,
            decimal? vICMSSTRet,
            decimal? vBCFCPSTRet,
            decimal? pFCPSTRet,
            decimal? vFCPSTRet,
            decimal? pRedBCEfet,
            decimal? vBCEfet,
            decimal? pICMSEfet,
            decimal? vICMSEfet)
        {
            InformarICMS(new ICMS60
            {
                CST = Csticms.Cst60,
                orig = orig,
                vBCSTRet = vBCSTRet,
                pST = pST,
                vICMSSTRet = vICMSSTRet,
                vBCFCPSTRet = vBCFCPSTRet,
                pFCPSTRet = pFCPSTRet,
                vFCPSTRet = vFCPSTRet,
                pRedBCEfet = pRedBCEfet,
                vBCEfet = vBCEfet,
                pICMSEfet = pICMSEfet,
                vICMSEfet = vICMSEfet
            });
        }

        public void SetICMS70(OrigemMercadoria orig,
            DeterminacaoBaseIcms modBC,
            decimal pRedBC,
            decimal vBC,
            decimal pICMS,
            decimal vICMS,
            decimal? vBCFCP,
            decimal? pFCP,
            decimal? vFCP,
            DeterminacaoBaseIcmsSt modBCST,
            decimal? pMVAST,
            decimal? pRedBCST,
            decimal vBCST,
            decimal pICMSST,
            decimal vICMSST,
            decimal? vBCFCPST,
            decimal? pFCPST,
            decimal? vFCPST,
            decimal? vICMSDeson,
            MotivoDesoneracaoIcms? motDesICMS)
        {
            InformarICMS(new ICMS70
            {
                CST = Csticms.Cst70,
                modBC = modBC,
                pRedBC = pRedBC,
                vBC = vBC,
                pICMS = pICMS,
                vICMS = vICMS,
                vBCFCP = vBCFCP,
                pFCP = pFCP,
                vFCP = vFCP,
                modBCST = modBCST,
                pMVAST = pMVAST,
                pRedBCST = pRedBCST,
                vBCST = vBCST,
                pICMSST = pICMSST,
                vICMSST = vICMSST,
                vBCFCPST = vBCFCPST,
                pFCPST = pFCPST,
                vICMSDeson = vICMSDeson,
                motDesICMS = motDesICMS
            });
        }

        public void SetICMS90(OrigemMercadoria orig,
            DeterminacaoBaseIcms modBC,
            decimal pRedBC,
            decimal vBC,
            decimal pICMS,
            decimal vICMS,
            decimal? vBCFCP,
            decimal? pFCP,
            decimal? vFCP,
            DeterminacaoBaseIcmsSt modBCST,
            decimal? pMVAST,
            decimal? pRedBCST,
            decimal vBCST,
            decimal pICMSST,
            decimal vICMSST,
            decimal? vBCFCPST,
            decimal? pFCPST,
            decimal? vFCPST,
            decimal? vICMSDeson,
            MotivoDesoneracaoIcms? motDesICMS)
        {
            InformarICMS(new ICMS90
            {
                CST = Csticms.Cst70,
                modBC = modBC,
                pRedBC = pRedBC,
                vBC = vBC,
                pICMS = pICMS,
                vICMS = vICMS,
                vBCFCP = vBCFCP,
                pFCP = pFCP,
                vFCP = vFCP,
                modBCST = modBCST,
                pMVAST = pMVAST,
                pRedBCST = pRedBCST,
                vBCST = vBCST,
                pICMSST = pICMSST,
                vICMSST = vICMSST,
                vBCFCPST = vBCFCPST,
                pFCPST = pFCPST,
                vICMSDeson = vICMSDeson,
                motDesICMS = motDesICMS
            });
        }
        #endregion

        #region Identificacao ICMS SN

        public void SetICMSSN101(OrigemMercadoria orig,
            decimal pCredSN, decimal vCredICMSSN)
        {
            InformarICMS(new ICMSSN101
            {
                orig = orig,
                CSOSN = Csosnicms.Csosn101,
                pCredSN = pCredSN,
                vCredICMSSN = vCredICMSSN
            });
        }

        public void SetICMSSN102(OrigemMercadoria orig)
        {
            InformarICMS(new ICMSSN102
            {
                orig = orig,
                CSOSN = Csosnicms.Csosn102
            });
        }

        public void SetICMSSN201(OrigemMercadoria orig,
            DeterminacaoBaseIcmsSt modBCST, decimal? pMVAST,
            decimal? pRedBCST, decimal vBCST, decimal pICMSST,
            decimal vICMSST, decimal? vBCFCPST, decimal? pFCPST, decimal? vFCPST,
            decimal pCredSN, decimal vCredICMSSN)
        {
            InformarICMS(new ICMSSN201
            {
                orig = orig,
                CSOSN = Csosnicms.Csosn201,
                modBCST = modBCST,
                pMVAST = pMVAST,
                pRedBCST = pRedBCST,
                vBCST = vBCST,
                pICMSST = pICMSST,
                vICMSST = vICMSST,
                vBCFCPST = vBCFCPST,
                pFCPST = pFCPST,
                vFCPST = vFCPST,
                pCredSN = pCredSN,
                vCredICMSSN = vCredICMSSN
            });
        }

        public void SetICMSSN202(OrigemMercadoria orig,
            DeterminacaoBaseIcmsSt modBCST, decimal? pMVAST,
            decimal? pRedBCST, decimal vBCST, decimal pICMSST,
            decimal vICMSST, decimal? vBCFCPST, decimal? pFCPST,
            decimal? vFCPST)
        {
            InformarICMS(new ICMSSN202
            {
                orig = orig,
                CSOSN = Csosnicms.Csosn202,
                modBCST = modBCST,
                pMVAST = pMVAST,
                pRedBCST = pRedBCST,
                vBCST = vBCST,
                pICMSST = pICMSST,
                vICMSST = vICMSST,
                vBCFCPST = vBCFCPST,
                pFCPST = pFCPST,
                vFCPST = vFCPST
            });
        }

        public void SetICMSSN500(OrigemMercadoria orig,
            decimal? vBCSTRet, decimal? pST, decimal? vICMSSTRet,
            decimal? vBCFCPSTRet, decimal? pFCPSTRet, decimal? vFCPSTRet,
            decimal? pRedBCEfet, decimal? vBCEfet, decimal? pICMSEfet,
            decimal? vICMSEfet)
        {
            InformarICMS(new ICMSSN500
            {
                orig = orig,
                CSOSN = Csosnicms.Csosn500,
                vBCSTRet = vBCSTRet,
                pST = pST,
                vICMSSTRet = vICMSSTRet,
                vBCFCPSTRet = vBCFCPSTRet,
                pFCPSTRet = pFCPSTRet,
                vFCPSTRet = vFCPSTRet,
                pRedBCEfet = pRedBCEfet,
                vBCEfet = vBCEfet,
                pICMSEfet = pICMSEfet,
                vICMSEfet = vICMSEfet
            });
        }

        public void SetICMSSN900(OrigemMercadoria orig,
            DeterminacaoBaseIcms? modBC, decimal? vBC, decimal? pRedBC,
            decimal? pICMS, decimal? vICMS, DeterminacaoBaseIcmsSt? modBCST,
            decimal? pMVAST, decimal? pRedBCST, decimal? vBCST,
            decimal? pICMSST, decimal? vICMSST, decimal? vBCFCPST,
            decimal? pFCPST, decimal? vFCPST, decimal? pCredSN,
            decimal? vCredICMSSN)
        {
            InformarICMS(new ICMSSN900
            {
                orig = orig,
                CSOSN = Csosnicms.Csosn900,
                modBC = modBC,
                vBC = vBC,
                pRedBC = pRedBC,
                pICMS = pICMS,
                vICMS = vICMS,
                modBCST = modBCST,
                pMVAST = pMVAST,
                pRedBCST = pRedBCST,
                vBCST = vBCST,
                pICMSST = pICMSST,
                vICMSST = vICMSST,
                vBCFCPST = vBCFCPST,
                pFCPST = pFCPST,
                vFCPST = vFCPST,
                pCredSN = pCredSN,
                vCredICMSSN = vCredICMSSN
            });
        }
        #endregion

        #region Identificacao IPI
        public void SetIPI(CSTIPI cst, decimal pIpi, decimal vBc,
            decimal vIpi, decimal qUnid, decimal vUnid,
            string clEnq, int cEnq,
            string cSelo, int qSelo,
            string cnpjProd)
        {
            InformarIPI(new IPITrib
            {
                CST = cst,
                pIPI = pIpi,
                vBC = vBc,
                vIPI = vBc,
                qUnid = qUnid,
                vUnid = vUnid,
            }, clEnq, cEnq, cSelo, qSelo, cnpjProd);
        }
        #endregion

        #region Identificacao PIS
        public void SetPISOutr(CSTPIS cst, decimal pPis,
             decimal qBCProd, decimal vAliqProd,
             decimal vBC, decimal vPIS)
        {
            InformarPIS(new PISOutr
            {
                CST = cst,
                pPIS = pPis,
                qBCProd = qBCProd,
                vAliqProd = vAliqProd,
                vBC = vBC,
                vPIS = vPIS
            });
        }

        public void SetPISQtde(CSTPIS cst, decimal qBCProd,
            decimal vAliqProd, decimal vPIS)
        {
            InformarPIS(new PISQtde
            {
                CST = cst,
                qBCProd = qBCProd,
                vAliqProd = vAliqProd,
                vPIS = vPIS
            });
        }

        public void SetPISST(decimal qBCProd,
            decimal vAliqProd, decimal pPis, decimal vBC,
            decimal vPis)
        {
            InformarPIS(new PISST
            {
                qBCProd = qBCProd,
                vAliqProd = vAliqProd,
                pPIS = pPis,
                vBC = vBC,
                vPIS = vPis
            });
        }
        #endregion

        #region Identificacao COFINS
        public void SetCOFINSAliq(CSTCOFINS cst, decimal vBC,
            decimal pCofins, decimal vCofins)
        {
            InformarCOFINS(new COFINSAliq
            {
                CST = cst,
                vBC = vBC,
                pCOFINS = pCofins,
                vCOFINS = vCofins

            });
        }

        public void SetCOFINSOutr(CSTCOFINS cst, decimal vBC,
            decimal pCofins, decimal qBcProd, decimal vAliqProd,
            decimal vCofins)
        {
            InformarCOFINS(new COFINSOutr
            {
                CST = cst,
                vBC = vBC,
                pCOFINS = pCofins,
                qBCProd = qBcProd,
                vAliqProd = vAliqProd,
                vCOFINS = vCofins
            });
        }

        public void SetCofinsQtde(CSTCOFINS cst, decimal qBcProd,
            decimal vAliqProd, decimal vCofins)
        {
            InformarCOFINS(new COFINSQtde
            {
                CST = cst,
                qBCProd = qBcProd,
                vAliqProd = vAliqProd,
                vCOFINS = vCofins
            });
        }

        public void SetCofinsST(decimal vBC, decimal pCofins,
            decimal qBCProd, decimal vAliqProd, decimal vCofins)
        {
            InformarCOFINS(new COFINSST
            {
                vBC = vBC,
                pCOFINS = pCofins,
                qBCProd = qBCProd,
                vAliqProd = vAliqProd,
                vCOFINS = vCofins
            });
        }
        #endregion

        #region Identificacao II
        public void SetII(decimal vBC, decimal vDespAdu,
            decimal vII, decimal vIOF)
        {
            InformarII(new II
            {
                vBC = vBC,
                vDespAdu = vDespAdu,
                vII = vII,
                vIOF = vIOF
            });
        }
        #endregion

        #region Identificacao ISSQN
        public void SetISSQN(decimal vBC, decimal vAliq, decimal vISSQN,
            long cMunFG, string cListServ,
            decimal vDeducao, decimal vOutro, decimal vDescIncond,
            decimal vDescCond, decimal vISSRet,
            IndicadorISS indISS, string cServico,
            long cMun, int cPais, string nProcesso,
            indIncentivo indIncentivo)
        {
            InformarISSQN(new ISSQN
            {
                vBC = vBC,
                vAliq = vAliq,
                vISSQN = vISSQN,
                cMunFG = cMunFG,
                cListServ = cListServ,
                vDeducao = vDeducao,
                vOutro = vOutro,
                vDescIncond = vDescIncond,
                vDescCond = vDescCond,
                vISSRet = vISSRet,
                indISS = indISS,
                cServico = cServico,
                cMun = cMun,
                cPais = cPais,
                nProcesso = nProcesso,
                indIncentivo = indIncentivo
            });
        }
        #endregion
    }
}
