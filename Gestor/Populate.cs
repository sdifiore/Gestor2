using System;
using System.Data.Entity;
using System.Linq;
using System.Web.UI.WebControls;
using Gestor.Models;


namespace Gestor
{
    public static class Populate
    {
        public static void Estrutura()
        {
            var db = new ApplicationDbContext();
            var model = db.Estruturas
                .Include(e => e.Produto)
                .Include(e => e.Sequencia)
                .ToList();
            string compAlias = Global.CompAlias;

          //  Insumo();

            foreach (var register in model)
            {
                register.Header = false;
                register.IdProd = "";

                if (register.Produto.Apelido != compAlias)
                {
                    register.Header = true;
                    compAlias = register.Produto.Apelido;
                    register.IdProd = FxEstrutura.IdProd(register);     // Z
                }

                register.AlrtSbPrdt = FxEstrutura.AlrtSbPrdt(register);     // R
                register.DescCompProc = FxEstrutura.DescCompProc(register); // G
                register.TpItmCst = FxEstrutura.TipoItemCusto(register);    // Q
                //register.UnidadeCompraId = FxEstrutura.UnidadeCompraId(register);    // H
                register.CustoUnitCompra = FxEstrutura.CustoUnitCompra(register);   // I
                register.QtEftvUntrCmpnt = FxEstrutura.QtEftvUntrCmpnt(register);   // O
                register.CstCmprUndPrd = FxEstrutura.CstCmprUndPrd(register);   // P
                register.PartCusto = FxEstrutura.PartCusto(register);   // N
                register.TempMaq = FxEstrutura.TempMaq(register);   // S
                register.QtdUndd = FxEstrutura.QtdUndd(register);  // T
                register.PsLiqdFnl = FxEstrutura.PsLiqdFnl(register);   // U
                register.PsLiqdPrcdt = FxEstrutura.PesoLiqPrec(register);   // V
                register.HrsModFnl = FxEstrutura.HrsModFnl(register);   // W
                register.HrsModPrec1 = FxEstrutura.HrsModPrec1(register);   // X
                register.HrsModPrec2 = FxEstrutura.HrsModPrec2(register);   // Y
                register.IdCmpnt = FxEstrutura.IdCmpnt(register);   // AA
                register.PdrHoraria = FxEstrutura.PdrHoraria(register);     // AB
                register.ProdComp = FxEstrutura.ProdComp(register);     // AC
                register.CstIndividual = FxEstrutura.CstIndividual(register);   // AD
                register.CstMtrlDrt = FxEstrutura.CstMtrlDrt(register);     // AE
                register.CstMtrlPrcd1 = FxEstrutura.CstMtrlPrcd1(register);     // AF
                register.CstMtrlPrcd2 = FxEstrutura.CstMtrlPrcd2(register);     // AG
                register.CstMtrlPrcd3 = FxEstrutura.CstMtrlPrcd3(register);     // AH
            }

            db.SaveChanges();
        }

            public static void Insumo()
        {
            var db = new ApplicationDbContext();
            var model = db.Insumos.Include(i => i.Finalidade).ToList();
            var estrutura = db.Estruturas.ToList();
            float dolar = db.Parametros.First().Dolar;

            foreach (var register in model)
            {
                register.PrcBrtCompra = Math.Abs(register.PrecoUsd) < Global.Tolerance
                    ? register.PrecoRs
                    : dolar * register.PrecoUsd;
                register.PrcBrtCompra *= 1 + register.Ipi;
                register.CrdtIcms = register.PrcBrtCompra / (1 + register.Ipi) * register.Icms;
                register.CrdtIpi = register.PrcBrtCompra / (1 + register.Ipi) * register.Ipi;
                register.CrdtPis = register.PrcBrtCompra / (1 + register.Ipi) * register.Pis;
                register.CrdtCofins = register.PrcBrtCompra / (1 + register.Ipi) * register.Cofins;
                register.SumCrdImpostos = register.CrdtIcms + register.CrdtIpi + register.CrdtPis + register.CrdtCofins;
                register.DspImportacao = register.PrcBrtCompra / (1 + register.Ipi) * register.DespImport;
                register.CustoExtra = register.PrcBrtCompra / (1 + register.Ipi) * register.DespExtra;
                register.Custo = register.PrcBrtCompra - register.CrdtIcms - register.CrdtPis - register.CrdtCofins +
                                 register.CustoExtra;
                string frase = XmlReader.Read("Revenda");
                if (register.Finalidade.Descricao != frase) register.Custo -= register.CrdtIpi;
                register.CustoUndCnsm = register.Custo * register.QtdUnddConsumo;
                register.PgtFornecImp = Math.Abs(register.DespImport) > Global.Tolerance
                    ? register.PrcBrtCompra - register.SumCrdImpostos - register.DspImportacao
                    : 0;
                register.UsoStru = estrutura.Count(e => e.Item == register.Apelido);
            }

            db.SaveChanges();
        }

        public static void Produto()
        {
            var db = new ApplicationDbContext();
            var model = db.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.ClasseCusto);

            foreach (var register in model)
            {
                register.PesoLiquidoCalc = FxProduto.PesoLiquidoCalc(register);     // Planilha 1, R
                register.ItemStru = FxProduto.ItemStru(register);       // S
                register.CustODirTotal = FxProduto.CustoDirTotal(register);     //T
                register.CstMatUltmEtapa = FxProduto.CstMatUltmEtapa(register);     // U
                register.CstMatEtapa1 = FxProduto.CstMatEtapa1(register);       // V
                register.CstMatEtapa2 = FxProduto.CstMatEtapa2(register);       // W
                register.CstMatEtapa3 = FxProduto.CstMatEtapa3(register);       // X
                register.CstTotMaterial = FxProduto.CstTotMaterial(register);   // Y
                register.CustoDirMod = FxProduto.CustoDirMod(register);     // Z
                register.HorasModUltmEtapa = FxProduto.HorasModUltmEtapa(register);       // AA
                register.HorasModEtapa1 = FxProduto.HorasModEtapa1(register);       // AB
                register.HorasModEtapa2 = FxProduto.HorasModEtapa2(register);       // AC
                register.HorasModTotal = FxProduto.HorasModTotal(register);     // AD
                register.CapProdHora = FxProduto.CapProdHora(register);     // AE
                register.LoteMinimo = FxProduto.LoteMinimo(register);       // AF
                register.UsoStru = FxProduto.UsoStru(register);     // AG
                register.CustoDir = FxProduto.CustoDir(register);       // AH
                register.RelModCstDir = FxProduto.RelModCstDir(register);       // AI
                register.PctMatEtapaFinal = FxProduto.PctMatEtapaFinal(register);        // AJ
                register.PctMatEtapa1 = FxProduto.PctMatEtapa1(register);       // AK
                register.PctMatEtapa2 = FxProduto.PctMatEtapa2(register);       // AL
                register.PctMatEtapa3 = FxProduto.PctMatEtapa3(register);       // AM
                register.CustoFixoTotal = FxProduto.CustoFixoTotal(register);       // Planilha 2, S
                register.MoiFabricacao = FxProduto.MoiFabricacao(register);     // T
                register.OutrosCustosFab = FxProduto.OutrosCustosFab(register);     // U
                register.ComacsComtexFpv = FxProduto.ComacsComtexFpv(register);     // V
                register.CustoFixoAdminLogFpv = FxProduto.CustoFixoAdminLogFpv(register);     // W
                register.RsMoiDespFabHMod = FxProduto.RsMoiDespFabHMod(register);     // X
                register.RsSgNAHMod = FxProduto.RsSgNAHMod(register);     // Y
                register.CustoFixoTotalAnr = FxProduto.CustoFixoTotalAnr(register);     // Z
                register.MoiFabricAnr = FxProduto.MoiFabricAnr(register);     // AA
                register.OutrosCustosFabricAnr = FxProduto.OutrosCustosFabricAnr(register);     // AB
                register.CustoFixoComacsCmtexAnr = FxProduto.CustoFixoComacsCmtexAnr(register);     // AC
                register.CustoFixoAdminAnr = FxProduto.CustoFixoAdminAnr(register);     // AD
                register.PropCustoFixoTotal = FxProduto.PropCustoFixoTotal(register);     // Planilha 4, T
                register.CstDirUnidade = FxProduto.CstDirUnidade(register);     // U
                register.CstIndirUnidade = FxProduto.CstIndirUnidade(register);     // V

            }

            db.SaveChanges();
        }

        public static void EncapTubos()
        {
            var db = new ApplicationDbContext();
            var model = db.EncapTuboes;

            foreach (var register in model)
            {
                register.PesoRevest = (register.DextRevest * register.DextRevest - register.DintRevest * register.DintRevest) * (float)Math.PI / 4 * register.DenRev / 1000;
                register.Resina = register.PesoRevest * (1 - register.PctCarga);
                register.Master = register.PesoRevest - register.Resina;
            }

            db.SaveChanges();
        }

        public static void Graxas()
        {
            var db = new ApplicationDbContext();
            var model = db.TotalParmGraxas;
            TotalParmGraxa data = model.First();
            data.MinHora = (float)db.ParmGraxas
                .Where(mh => mh.Totaliza)
                .Sum(g => g.Pesagem);
            data.KgH = 10 / data.MinHora * 60;
            db.SaveChanges();

            var graxas = db.Graxas;
            string comp = XmlReader.Read("PesagemCarga");
            var pesagem = db.ParmGraxas.SingleOrDefault(g => g.Descricao == comp);

            if (pesagem == null)
            {
                DbLogger.Log(Reason.Error, $"Parâmetro de graxa {comp} não encontrado");
                throw new Exception($"Parâmetro de graxa {comp} não encontrado");
            }

            foreach (var graxa in graxas)
            {
                graxa.Ptfe = 1 - graxa.PctSilicone - graxa.PctSilica;
                graxa.PesagemMinUn = 60 / pesagem.KgH * graxa.Peso;
                graxa.Mistura = 60 / data.KgH * graxa.Peso;
                graxa.LoteMinino = 16 / graxa.Peso;
                graxa.Ptfe = graxa.Peso * graxa.LoteMinino * graxa.PctPtfe;
                graxa.Silicone = graxa.Peso * graxa.LoteMinino * graxa.PctSilicone;
                graxa.Silica = graxa.Peso * graxa.LoteMinino * graxa.PctSilica;
                graxa.PesagemH = (float)pesagem.Pesagem / 60;
                graxa.MisturaH = data.MinHora / 60;
                graxa.EmbalarH = graxa.EmbalagemMedida * graxa.LoteMinino / 60;
                graxa.RotularH = graxa.Rotulagem * graxa.LoteMinino / 60;
            }

            db.SaveChanges();
        }

        public static void PreForma()
        {
            var db = new ApplicationDbContext();
            var model = db.PreFormas.ToList();
            string comp1 = XmlReader.Read("CompactacaoPTFE");
            string comp2 = XmlReader.Read("DensidadePadraoPreForma");

            foreach (var register in model)
            {
                register.SecaoPf = (register.FormaDiamE * register.FormaDiamE - register.VaretaDiamI * register.VaretaDiamI) 
                    * (float)Math.PI / 400;
                register.KgfPrensagem = db.PadroesFixos.Single(p => p.Descricao == comp1).Valor * register.SecaoPf;
                register.PressaoOleo = register.DiamPistaoHidraulico < Global.Tolerance
                    ? float.MaxValue
                    : register.SecaoPf / (register.DiamPistaoHidraulico * register.DiamPistaoHidraulico
                    * (float)Math.PI / 400) * db.PadroesFixos.Single(p => p.Descricao == comp1).Valor;
                register.KgPfUmida = register.FormaDiamE * register.FormaDiamE * (float)Math.PI / 4 
                    * register.Comprimento / 1000 * db.PadroesFixos.Single(p => p.Descricao == comp2).Valor / 1000;
            }

            db.SaveChanges();
        }

        public static void ResinaPtfe()
        {
            var db = new ApplicationDbContext();
            var model = db.ResinasPtfe.ToList();

            foreach (var resina in model)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == resina.InsumoId);
                resina.Custo = insumo == null
                    ? 0
                    : insumo.CustoUndCnsm;
            }

            db.SaveChanges();
        }

        public static void ProcTubos()
        {
            var db = new ApplicationDbContext();
            var model = db.ProcTubos.ToList();

            foreach (var register in model)
            {
                register.Cadastro = register.Cadastro;
                register.CodResinaAdotada = FxTubo.ResinaAdotada(register);      // L
                register.RrMaxResina = FxTubo.RrMaxResina(register);        // M
                register.BicoIdeal = FxTubo.BicoIdeal(register);        // N
                register.MandrilIdeal = FxTubo.MandrilIdeal(register);      // O
                register.SecaoExtrudado = FxTubo.SecaoExtrudado(register);      // P
                register.PerimSecaoExtrud = FxTubo.PerimSecaoExtrud(register);      // Q
                register.DiamExtFinalTubo = FxTubo.DiamExtFinalTubo(register);      // R
                register.DiamIntFinalTubo = FxTubo.DiamIntFinalTubo(register);      // S
                register.PesoUnKgMLiq = FxTubo.PesoUnKgMLiq(register);      // T
                register.PtfeKgM = FxTubo.PtfeKgM(register);      // U
                register.LubrKgM = FxTubo.LubrKgM(register);      // V
                register.CodPreformaIdeal = FxTubo.CodPreformaIdeal(register);      // W
                register.Rr = FxTubo.Rr(register);      // X
                register.LanceSinterizado = FxTubo.LanceSinterizado(register);      // Y
                register.VextrUmidoMin = FxTubo.VextrUmidoMin(register);      // AE
                register.VsintMMin = FxTubo.VsintMMin(register);      // AG
                register.VSintResultante = FxTubo.VSintResultante(register);      // AI
                register.VelEfetExtrusaoMMin = FxTubo.VelEfetExtrusaoMMin(register);        // AO
                register.TuSinterizadoMinM = FxTubo.TuSinterizadoMinM(register);        // AP
                register.TuProducaoMinM = FxTubo.TuProducaoMinM(register);        // AQ
                register.QtPCusto = FxTubo.QtPCusto(register);        // BG
                register.QtPf = FxTubo.QtPf(register);        // AA
                register.ConfAdtDosLub = FxTubo.ConfAdtDosLub(register);        // AK
                register.Peneiramento = FxTubo.Peneiramento(register);        // AL
                register.MisturaMinM = FxTubo.MisturaMinM(register);        // AM
                register.PreparoExtrusMinM = FxTubo.PreparoExtrusMinM(register);        // AN
                register.TuInspUdc3MinM = FxTubo.TuInspUdc3MinM(register);        // AR
                register.TuTesteEstanqMinM = FxTubo.TuTesteEstanqMinM(register);        // AS
                register.TuTesteEstouroMinM = FxTubo.TuTesteEstouroMinM(register);        // AT
                register.TuEmbalMinM = FxTubo.TuEmbalMinM(register);        // AU
                register.TuTotalMinM = FxTubo.TuTotalMinM(register);        // AV
                register.CustoPtfeRsM = FxTubo.CustoPtfeRsM(register);        // AW
                register.CustoAditivosRsM = FxTubo.CustoAditivosRsM(register);        // AX
                register.CustoLubrifRsM = FxTubo.CustoLubrifRsM(register);        // AY
                register.CustoEmbalRsM = FxTubo.CustoEmbalRsM(register);        // AZ
                register.CustoModRsM = FxTubo.CustoModRsM(register);        // BA
                register.CustoDiretoTotalRsM = FxTubo.CustoDiretoTotalRsM(register);        // BB
                // ****************** Cálculo de BC depende de Planilha 2
                // ****************** Cálculo de BD depende de BC
                register.CapProducaoMH = FxTubo.CapProducaoMH(register);      // BE
                register.PvCalculadoRsM = FxTubo.PvCalculadoRsM(register);      // BH
            }

            db.SaveChanges();
        }

        public static void PrecoNacional()
        {
            var db = new ApplicationDbContext();
            var model = db.PrecosNacionais.ToList();

            foreach (var register in model)
            {
                register.I18Nivel1 = FxPrecoNacional.I18Nivel1(register);       // G
                register.I18Nivel2 = FxPrecoNacional.I18Nivel2(register);       // H
                register.I18Nivel3 = FxPrecoNacional.I18Nivel3(register);       // I
                register.I12Nivel1 = FxPrecoNacional.I12Nivel1(register);       // J
                register.I12Nivel2 = FxPrecoNacional.I12Nivel2(register);       // K
                register.I12Nivel3 = FxPrecoNacional.I12Nivel3(register);       // L
                register.I7Nivel1 = FxPrecoNacional.I7Nivel1(register);       // M
                register.I7Nivel2 = FxPrecoNacional.I7Nivel2(register);       // N
                register.I7Nivel3 = FxPrecoNacional.I7Nivel3(register);       // O
            }

            db.SaveChanges();
        }

        public static void PrecoExportacao()
        {
            var db = new ApplicationDbContext();
            var model = db.PrecosExpostacao
                .Include(p => p.CondicaoPreco)
                .ToList();

            foreach (var register in model)
            {
                if (register.Apelido != "--")
                {
                    register.IEfetiva = FxPrecoExportacao.IEfetiva(register);     // O
                    register.De2A5 = FxPrecoExportacao.De2A5(register);     // F
                    register.De5A10 = FxPrecoExportacao.De5A10(register);     // G
                    register.De10A20 = FxPrecoExportacao.De10A20(register);     // H
                    register.Acima20 = FxPrecoExportacao.Acima20(register);     // I
                    register.PvFobMax = FxPrecoExportacao.PvFobMax(register);     // S
                    register.PvFobMin = FxPrecoExportacao.PvFobMin(register);     // V 
                    register.ValorCifPtfe = FxPrecoExportacao.ValorCifPtfe(register);     // W
                    register.RelPtfeSobrePv = FxPrecoExportacao.RelPtfeSobrePv(register);     // X
                }
            }

            db.SaveChanges();
        }

        public static void DfxProdRev()
        {
            var db = new ApplicationDbContext();
            var model = db.DfxProdRevs.ToList();

            foreach (var register in model)
            {
                register.ValorCompra = FxDfxProdRev.ValorCompra(register);      // G
                register.RateioDfixProduto = FxDfxProdRev.RateioDfixProduto(register);      // H ** Depende de Desp Fixas em Planilha 2, com erro
                register.RateioDfixProdutoUnitario = FxDfxProdRev.RateioDfixProdutoUnitario(register);      // I
                register.DespsFabrica = FxDfxProdRev.DespsFabrica(register);      // K ** Depende de Desp Fixas em Planilha 2, com erro
                register.DespsDepComercial = FxDfxProdRev.DespsDepComercial(register);      // L ** Depende de Desp Fixas em Planilha 2, com erro
                register.DespsDeptAdminLog = FxDfxProdRev.DespsDeptAdminLog(register);      // M ** Depende de Desp Fixas em Planilha 2, com erro
                register.QtdRolos = FxDfxProdRev.QtdRolos(register);      // N
                register.RateioDfixUnidade = FxDfxProdRev.RateioDfixUnidade(register);      // O
                register.ProporcaoCusto = FxDfxProdRev.ProporcaoCusto(register, model.Sum(m => m.ValorCompra));      // P
                register.ProporcaoEmCxs = FxDfxProdRev.ProporcaoEmCxs(register, model.Sum(m => m.QtdCompra));      // Q
            }

            db.SaveChanges();
        }
    }
}