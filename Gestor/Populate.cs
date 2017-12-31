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
                //register.UnidadeCompraId = FxEstrutura.UnidadeCompraId(register);    // H *********************
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
                register.CustoIndiretoRsM = FxTubo.CustoIndiretoRsM(register);        // BC
                register.CustoTotalRsM = FxTubo.CustoTotalRsM(register);        // BD
                register.PvRsKg = FxTubo.PvRsKg(register);      // BE
                register.CapProducaoMH = FxTubo.CapProducaoMH(register);      // BF
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

        public static void PlanejMod()
        {
            var db = new ApplicationDbContext();
            var model = db.PlanejMods.ToList();

            foreach (var register in model)
            {
                register.AnoMenos11 = FxPlanejMod.AnoMenos11(register);     // Q
                register.AnoMenos10 = FxPlanejMod.AnoMenos10(register);     // R
                register.AnoMenos9 = FxPlanejMod.AnoMenos9(register);     // S
                register.AnoMenos8 = FxPlanejMod.AnoMenos8(register);     // T
                register.AnoMenos7 = FxPlanejMod.AnoMenos7(register);     // U
                register.AnoMenos6 = FxPlanejMod.AnoMenos6(register);     // V
                register.AnoMenos5 = FxPlanejMod.AnoMenos5(register);     // W
                register.AnoMenos4 = FxPlanejMod.AnoMenos4(register);     // X
                register.AnoMenos3 = FxPlanejMod.AnoMenos3(register);     // Y
                register.AnoMenos2 = FxPlanejMod.AnoMenos2(register);     // Z
                register.AnoMenos1 = FxPlanejMod.AnoMenos1(register);     // AA
                register.Ano = FxPlanejMod.Ano(register);     // AB
            }

            db.SaveChanges();
        }

        public static void PlanejCompra()
        {
            var db = new ApplicationDbContext();
            var model = db.PlanejCompras.ToList();

            foreach (var register in model)
            {
                register.FatorConsumo = FxPlanejCompra.FatorConsumo(register);        // R
                register.LoteCompra = FxPlanejCompra.LoteCompra(register);        // S
                register.EstoqueMinimo = FxPlanejCompra.EstoqueMinimo(register);        // T
                register.PrecoUnitarioBruto = FxPlanejCompra.PrecoUnitarioBruto(register);        // U
                register.CustoUnitario = FxPlanejCompra.CustoUnitario(register);        // V
                register.CreditoUnitIcms = FxPlanejCompra.CreditoUnitIcms(register);        // w ** Checar fórmula! É a mesma da anterior! Assumindo valor diferente na função por dedução da planilha.
                register.CreditoUnitIpi = FxPlanejCompra.CreditoUnitIpi(register);        // X
                register.CreditoUnitPis = FxPlanejCompra.CreditoUnitPis(register);        // Y
                register.CreditoUnitCofins = FxPlanejCompra.CreditoUnitCofins(register);        // Z
                register.PagFornecImport = FxPlanejCompra.PagFornecImport(register);        // AA
                register.IiDespImport = FxPlanejCompra.IiDespImport(register);        // AB
                register.MesRefPag1Fornec = FxPlanejCompra.MesRefPag1Fornec(register);        // AC
                register.MesRefPag2Fornec = FxPlanejCompra.MesRefPag2Fornec(register);        // AD
                register.PctPag1 = FxPlanejCompra.PctPag1(register);        // AE
                register.EstoqueInicial = FxPlanejCompra.EstoqueInicial(register);        // AF
                register.NCMPAnoMenos11 = FxPlanejCompra.NCMPAnoMenos11(register);        // AG
                register.NCMPAnoMenos10 = FxPlanejCompra.NCMPAnoMenos10(register);        // AH
                register.NCMPAnoMenos9 = FxPlanejCompra.NCMPAnoMenos9(register);        // AI
                register.NCMPAnoMenos8 = FxPlanejCompra.NCMPAnoMenos8(register);        // AJ
                register.NCMPAnoMenos7 = FxPlanejCompra.NCMPAnoMenos7(register);        // AK
                register.NCMPAnoMenos6 = FxPlanejCompra.NCMPAnoMenos6(register);        // AL
                register.NCMPAnoMenos5 = FxPlanejCompra.NCMPAnoMenos5(register);        // AM
                register.NCMPAnoMenos4 = FxPlanejCompra.NCMPAnoMenos4(register);        // AN
                register.NCMPAnoMenos3 = FxPlanejCompra.NCMPAnoMenos3(register);        // AO
                register.NCMPAnoMenos2 = FxPlanejCompra.NCMPAnoMenos2(register);        // AP
                register.NCMPAnoMenos1 = FxPlanejCompra.NCMPAnoMenos1(register);        // AQ
                register.NCMPAno = FxPlanejCompra.NCMPAno(register);        // AR
                register.QCMes1 = FxPlanejCompra.QCMes1(register);        // AS
                register.SFCMAnoMenos11 = FxPlanejCompra.SFCMAnoMenos11(register);        // BF
                register.QCMes2 = FxPlanejCompra.QCMes2(register);        // AT
                register.SFCMAnoMenos10 = FxPlanejCompra.SFCMAnoMenos10(register);        // BG
                register.QCMes3 = FxPlanejCompra.QCMes3(register);        // AU
                register.SFCMAnoMenos9 = FxPlanejCompra.SFCMAnoMenos9(register);        // BH
                register.QCMes4 = FxPlanejCompra.QCMes4(register);        // AV
                register.SFCMAnoMenos8 = FxPlanejCompra.SFCMAnoMenos8(register);        // BI
                register.QCMes5 = FxPlanejCompra.QCMes5(register);        // AW
                register.SFCMAnoMenos7 = FxPlanejCompra.SFCMAnoMenos7(register);        // BJ
                register.QCMes6 = FxPlanejCompra.QCMes6(register);        // AX
                register.SFCMAnoMenos6 = FxPlanejCompra.SFCMAnoMenos6(register);        // BK
                register.QCMes7 = FxPlanejCompra.QCMes7(register);        // AY
                register.SFCMAnoMenos5 = FxPlanejCompra.SFCMAnoMenos5(register);        // BL
                register.QCMes8 = FxPlanejCompra.QCMes8(register);        // AZ
                register.SFCMAnoMenos4 = FxPlanejCompra.SFCMAnoMenos4(register);        // BM
                register.QCMes9 = FxPlanejCompra.QCMes9(register);        // BA
                register.SFCMAnoMenos3 = FxPlanejCompra.SFCMAnoMenos3(register);        // BN
                register.QCMes10 = FxPlanejCompra.QCMes10(register);        // BB
                register.SFCMAnoMenos2 = FxPlanejCompra.SFCMAnoMenos2(register);        // BO
                register.QCMes11 = FxPlanejCompra.QCMes11(register);        // BC
                register.SFCMAnoMenos1 = FxPlanejCompra.SFCMAnoMenos1(register);        // BP
                register.QCMes12 = FxPlanejCompra.QCMes12(register);        // BD
                register.SFCMAno = FxPlanejCompra.SFCMAno(register);        // BQ
                register.TotalPeriodo = FxPlanejCompra.TotalPeriodo(register);        // BE
                register.VBCMes1 = FxPlanejCompra.VBCMes1(register);        // BR
                register.VBCMes2 = FxPlanejCompra.VBCMes2(register);        // BS
                register.VBCMes3 = FxPlanejCompra.VBCMes3(register);        // BT
                register.VBCMes4 = FxPlanejCompra.VBCMes4(register);        // BU 
                register.VBCMes5 = FxPlanejCompra.VBCMes5(register);        // BV
                register.VBCMes6 = FxPlanejCompra.VBCMes6(register);        // BW
                register.VBCMes7 = FxPlanejCompra.VBCMes7(register);        // BX
                register.VBCMes8 = FxPlanejCompra.VBCMes8(register);        // BY
                register.VBCMes9 = FxPlanejCompra.VBCMes9(register);        // BZ
                register.VBCMes10 = FxPlanejCompra.VBCMes10(register);        // CA
                register.VBCMes11 = FxPlanejCompra.VBCMes11(register);        // CB
                register.VBCMes12 = FxPlanejCompra.VBCMes12(register);        // CC
                register.PFNMes1 = FxPlanejCompra.PFNMesN(register, 0);        // CD
                register.PFNMes2 = FxPlanejCompra.PFNMesN(register, 1);        // CE
                register.PFNMes3 = FxPlanejCompra.PFNMesN(register, 2);        // CF
                register.PFNMes4 = FxPlanejCompra.PFNMesN(register, 3);        // CG
                register.PFNMes5 = FxPlanejCompra.PFNMesN(register, 4);        // CH
                register.PFNMes6 = FxPlanejCompra.PFNMesN(register, 5);        // CI
                register.PFNMes7 = FxPlanejCompra.PFNMesN(register, 6);        // CJ
                register.PFNMes8 = FxPlanejCompra.PFNMesN(register, 7);        // CK
                register.PFNMes9 = FxPlanejCompra.PFNMesN(register, 8);        // CL
                register.PFNMes10 = FxPlanejCompra.PFNMesN(register, 9);        // CM
                register.PFNMes11 = FxPlanejCompra.PFNMesN(register, 10);        // CN
                register.PFNMes12 = FxPlanejCompra.PFNMesN(register, 11);        // CO
                register.PFIMes1 = FxPlanejCompra.PFIMes1(register, 0);        // CP
                register.PFIMes2 = FxPlanejCompra.PFIMes1(register, 1);        // CQ
                register.PFIMes3 = FxPlanejCompra.PFIMes1(register, 2);        // CR
                register.PFIMes4 = FxPlanejCompra.PFIMes1(register, 3);        // CS
                register.PFIMes5 = FxPlanejCompra.PFIMes1(register, 4);        // CT
                register.PFIMes6 = FxPlanejCompra.PFIMes1(register, 5);        // CU
                register.PFIMes7 = FxPlanejCompra.PFIMes1(register, 6);        // CV
                register.PFIMes8 = FxPlanejCompra.PFIMes1(register, 7);        // CW
                register.PFIMes9 = FxPlanejCompra.PFIMes1(register, 8);        // CX
                register.PFIMes10 = FxPlanejCompra.PFIMes1(register, 9);        // CY
                register.PFIMes11 = FxPlanejCompra.PFIMes1(register, 10);        // CZ
                register.PFIMes12 = FxPlanejCompra.PFIMes1(register, 11);        // DA
                register.PIIDIMes1 = FxPlanejCompra.PIIDIMes1(register);        // DB
                register.PIIDIMes2 = FxPlanejCompra.PIIDIMes2(register);        // DC
                register.PIIDIMes3 = FxPlanejCompra.PIIDIMes3(register);        // DD
                register.PIIDIMes4 = FxPlanejCompra.PIIDIMes4(register);        // DE
                register.PIIDIMes5 = FxPlanejCompra.PIIDIMes5(register);        // DF
                register.PIIDIMes6 = FxPlanejCompra.PIIDIMes6(register);        // DG
                register.PIIDIMes7 = FxPlanejCompra.PIIDIMes7(register);        // DH
                register.PIIDIMes8 = FxPlanejCompra.PIIDIMes8(register);        // DI
                register.PIIDIMes9 = FxPlanejCompra.PIIDIMes9(register);        // DJ
                register.PIIDIMes10 = FxPlanejCompra.PIIDIMes10(register);        // DK
                register.PIIDIMes11 = FxPlanejCompra.PIIDIMes11(register);        // DL
                register.PIIDIMes12 = FxPlanejCompra.PIIDIMes12(register);        // DM
                register.VCCMes1 = FxPlanejCompra.VCCMes1(register);        // DN
                register.VCCMes2 = FxPlanejCompra.VCCMes2(register);        // DO
                register.VCCMes3 = FxPlanejCompra.VCCMes3(register);        // DP
                register.VCCMes4 = FxPlanejCompra.VCCMes4(register);        // DQ
                register.VCCMes5 = FxPlanejCompra.VCCMes5(register);        // DR
                register.VCCMes6 = FxPlanejCompra.VCCMes6(register);        // DS
                register.VCCMes7 = FxPlanejCompra.VCCMes7(register);        // DT
                register.VCCMes8 = FxPlanejCompra.VCCMes8(register);        // DU
                register.VCCMes9 = FxPlanejCompra.VCCMes9(register);        // DV
                register.VCCMes10 = FxPlanejCompra.VCCMes10(register);        // DW
                register.VCCMes11 = FxPlanejCompra.VCCMes11(register);        // DX
                register.VCCMes12 = FxPlanejCompra.VCCMes12(register);        // DY
                register.VCIcmsMes1 = FxPlanejCompra.VCIcmsMes1(register);        // DZ  ** Dependem do cálculo do ICMS. Verificar acima
                register.VCIcmsMes2 = FxPlanejCompra.VCIcmsMes2(register);        // EA
                register.VCIcmsMes3 = FxPlanejCompra.VCIcmsMes3(register);        // EB
                register.VCIcmsMes4 = FxPlanejCompra.VCIcmsMes4(register);        // EC
                register.VCIcmsMes5 = FxPlanejCompra.VCIcmsMes5(register);        // ED
                register.VCIcmsMes6 = FxPlanejCompra.VCIcmsMes6(register);        // EE
                register.VCIcmsMes7 = FxPlanejCompra.VCIcmsMes7(register);        // EF
                register.VCIcmsMes8 = FxPlanejCompra.VCIcmsMes8(register);        // EG
                register.VCIcmsMes9 = FxPlanejCompra.VCIcmsMes9(register);        // EH
                register.VCIcmsMes10 = FxPlanejCompra.VCIcmsMes10(register);        // EI
                register.VCIcmsMes11 = FxPlanejCompra.VCIcmsMes11(register);        // EJ
                register.VCIcmsMes12 = FxPlanejCompra.VCIcmsMes12(register);        // EK
                register.VCIpiMes1 = FxPlanejCompra.VCIpiMes1(register);        // EL
                register.VCIpiMes2 = FxPlanejCompra.VCIpiMes2(register);        // EM
                register.VCIpiMes3 = FxPlanejCompra.VCIpiMes3(register);        // EN
                register.VCIpiMes4 = FxPlanejCompra.VCIpiMes4(register);        // EO
                register.VCIpiMes5 = FxPlanejCompra.VCIpiMes5(register);        // EP
                register.VCIpiMes6 = FxPlanejCompra.VCIpiMes6(register);        // EQ
                register.VCIpiMes7 = FxPlanejCompra.VCIpiMes7(register);        // ER
                register.VCIpiMes8 = FxPlanejCompra.VCIpiMes8(register);        // ES
                register.VCIpiMes9 = FxPlanejCompra.VCIpiMes9(register);        // ET
                register.VCIpiMes10 = FxPlanejCompra.VCIpiMes10(register);        // EU
                register.VCIpiMes11 = FxPlanejCompra.VCIpiMes11(register);        // EV
                register.VCIpiMes12 = FxPlanejCompra.VCIpiMes12(register);        // EW
                register.CPisCofinsMes1 = FxPlanejCompra.CPisCofinsMes1(register);        // EX
                register.CPisCofinsMes2 = FxPlanejCompra.CPisCofinsMes2(register);        // EY
                register.CPisCofinsMes3 = FxPlanejCompra.CPisCofinsMes3(register);        // EZ
                register.CPisCofinsMes4 = FxPlanejCompra.CPisCofinsMes4(register);        // FA
                register.CPisCofinsMes5 = FxPlanejCompra.CPisCofinsMes5(register);        // FB
                register.CPisCofinsMes6 = FxPlanejCompra.CPisCofinsMes6(register);        // FC
                register.CPisCofinsMes7 = FxPlanejCompra.CPisCofinsMes7(register);        // FD
                register.CPisCofinsMes8 = FxPlanejCompra.CPisCofinsMes8(register);        // FE
                register.CPisCofinsMes9 = FxPlanejCompra.CPisCofinsMes9(register);        // FF
                register.CPisCofinsMes10 = FxPlanejCompra.CPisCofinsMes10(register);        // FG
                register.CPisCofinsMes11 = FxPlanejCompra.CPisCofinsMes11(register);        // FH
                register.CPisCofinsMes12 = FxPlanejCompra.CPisCofinsMes12(register);        // FI
                register.MediaMensal = FxPlanejCompra.MediaMensal(register);        // FJ
            }

            db.SaveChanges();
        }

        public static void PlanejNecessidades()
        {
            var db = new ApplicationDbContext();
            var model = db.Estruturas.ToList();

            foreach (var stru in model)
            {
                stru.SetorProducao = FxPlanejNecessidade.SetorProducao(stru);       // T
                stru.Categoria = FxPlanejNecessidade.Categoria(stru);       // U
                stru.ListaPlanejProducao = FxPlanejNecessidade.ListaPlanejProducao(stru);       // W    *********** Calcular primeiro PnalejProdução
            }

            db.SaveChanges();
        }

        public static void PlanejVendas()
        {
            var db = new ApplicationDbContext();
            var model = db.PlanejVendas.ToList();

            foreach (var item in model)
            {
                item.PesoUnitario = FxPlanejVenda.PesoUnitario(item);       // G
                item.HorasMod = FxPlanejVenda.HorasMod(item);       // H
                item.CustoDiretoTotal = FxPlanejVenda.CustoDiretoTotal(item);       // I
                item.CustoDiretoMats = FxPlanejVenda.CustoDiretoMats(item);       // J
                item.CustoDiretoMod = FxPlanejVenda.CustoDiretoMod(item);       // K
                item.CustoFixoFabrica = FxPlanejVenda.CustoFixoFabrica(item);       // L
                item.CustoFixAdmCom = FxPlanejVenda.CustoFixAdmCom(item);       // M
                item.AliquotaIpi = FxPlanejVenda.AliquotaIpi(item);       // O
                item.QvQtNacAnoMenos11 = FxPlanejVenda.QvQtNacAnoMenos11(item);     // P
                item.QvQtNacAnoMenos10 = FxPlanejVenda.QvQtNacAnoMenos10(item);     // Q
                item.QvQtNacAnoMenos09 = FxPlanejVenda.QvQtNacAnoMenos9(item);     // R
                item.QvQtNacAnoMenos08 = FxPlanejVenda.QvQtNacAnoMenos8(item);     // S
                item.QvQtNacAnoMenos07 = FxPlanejVenda.QvQtNacAnoMenos7(item);     // T
                item.QvQtNacAnoMenos06 = FxPlanejVenda.QvQtNacAnoMenos6(item);     // U
                item.QvQtNacAnoMenos05 = FxPlanejVenda.QvQtNacAnoMenos5(item);     // V
                item.QvQtNacAnoMenos04 = FxPlanejVenda.QvQtNacAnoMenos4(item);     // W
                item.QvQtNacAnoMenos03 = FxPlanejVenda.QvQtNacAnoMenos3(item);     // X
                item.QvQtNacAnoMenos02 = FxPlanejVenda.QvQtNacAnoMenos2(item);     // Y
                item.QvQtNacAnoMenos01 = FxPlanejVenda.QvQtNacAnoMenos1(item);     // Z
                item.QvQtNacAno00 = FxPlanejVenda.QvQtNacAno(item);     // AA
                item.QtNacMediaMensal = FxPlanejVenda.QtNacMediaMensal(item);     // AB
                item.PvMed1o3m = FxPlanejVenda.PvMed1o3m(item);     // AC
                item.PvMed2o3m = FxPlanejVenda.PvMed2o3m(item);     // AD
                item.PvMed3o3m = FxPlanejVenda.PvMed3o3m(item);     // AE
                item.PvMed4o3m = FxPlanejVenda.PvMed4o3m(item);     // AF
                item.PvNacAdotado = FxPlanejVenda.PvNacAdotado(item);     // AG
                item.StMedia = FxPlanejVenda.StMedia(item);     // AH
                item.IcmsMedio = FxPlanejVenda.IcmsMedio(item);     // AI
                item.ComissaoMediaNac = FxPlanejVenda.ComissaoMediaNac(item);     // AJ
                item.FreteNacPct = FxPlanejVenda.FreteNacPct(item);     // AK
                item.PrazoRecebMedioNac = FxPlanejVenda.PrazoRecebMedioNac(item);     // AL
                item.MesRecebMedNac = FxPlanejVenda.MesRecebMedNac(item);     // AM
                item.QtExpAnoMenos11 = FxPlanejVenda.QtExpAnoMenos11(item);     // AN
                item.QtExpAnoMenos10 = FxPlanejVenda.QtExpAnoMenos10(item);     // AO
                item.QtExpAnoMenos09 = FxPlanejVenda.QtExpAnoMenos09(item);     // AP
                item.QtExpAnoMenos08 = FxPlanejVenda.QtExpAnoMenos08(item);     // AQ
                item.QtExpAnoMenos07 = FxPlanejVenda.QtExpAnoMenos07(item);     // AR
                item.QtExpAnoMenos06 = FxPlanejVenda.QtExpAnoMenos06(item);     // AS
                item.QtExpAnoMenos05 = FxPlanejVenda.QtExpAnoMenos05(item);     // AT
                item.QtExpAnoMenos04 = FxPlanejVenda.QtExpAnoMenos04(item);     // AU
                item.QtExpAnoMenos03 = FxPlanejVenda.QtExpAnoMenos03(item);     // AV
                item.QtExpAnoMenos02 = FxPlanejVenda.QtExpAnoMenos02(item);     // AW
                item.QtExpAnoMenos01 = FxPlanejVenda.QtExpAnoMenos01(item);     // AX
                item.QtExpAno00 = FxPlanejVenda.QtExpAno00(item);     // AY
                item.QtExpMediaMensal = FxPlanejVenda.QtExpMediaMensal(item);     // AZ
                item.PvMedEx1o3m = FxPlanejVenda.PvMedEx1o3m(item);     // BA
                item.PvMedEx2o3m = FxPlanejVenda.PvMedEx2o3m(item);     // BB
                item.PvMedEx3o3m = FxPlanejVenda.PvMedEx3o3m(item);     // BC
                item.PvMedEx4o3m = FxPlanejVenda.PvMedEx4o3m(item);     // BD
                item.PvMedExAdotado = FxPlanejVenda.PvMedExAdotado(item);     // BE
                item.ComissaoExpPct = FxPlanejVenda.ComissaoExpPct(item);     // BF
                item.PrazoRecebMedExp = FxPlanejVenda.PrazoRecebMedExp(item);     // BG
                item.MesRecebMedExp = FxPlanejVenda.MesRecebMedExp(item);     // BH
                item.PqQtNacAnoMenos11 = FxPlanejVenda.PqQtNacAnoMenos11(item);     // BO
                item.PqQtNacAnoMenos10 = FxPlanejVenda.PqQtNacAnoMenos10(item);     // BP
                item.PqQtNacAnoMenos09 = FxPlanejVenda.PqQtNacAnoMenos09(item);     // BQ
                item.PqQtNacAnoMenos08 = FxPlanejVenda.PqQtNacAnoMenos08(item);     // BR
                item.PqQtNacAnoMenos07 = FxPlanejVenda.PqQtNacAnoMenos07(item);     // BS
                item.PqQtNacAnoMenos06 = FxPlanejVenda.PqQtNacAnoMenos06(item);     // BT
                item.PqQtNacAnoMenos05 = FxPlanejVenda.PqQtNacAnoMenos05(item);     // BU
                item.PqQtNacAnoMenos04 = FxPlanejVenda.PqQtNacAnoMenos04(item);     // BV
                item.PqQtNacAnoMenos03 = FxPlanejVenda.PqQtNacAnoMenos03(item);     // BW
                item.PqQtNacAnoMenos02 = FxPlanejVenda.PqQtNacAnoMenos02(item);     // BX
                item.PqQtNacAnoMenos01 = FxPlanejVenda.PqQtNacAnoMenos01(item);     // BY
                item.PqQtNacAno00 = FxPlanejVenda.PqQtNacAno00(item);     // BZ
                item.PqQtNacTotal = FxPlanejVenda.PqQtNacTotal(item);     // CA
                item.PplKgNacAnoMenos12 = FxPlanejVenda.PplKgNacAnoMenos12(item);     // CB
                item.PplKgNacAnoMenos11 = FxPlanejVenda.PplKgNacAnoMenos11(item);     // CC
                item.PplKgNacAnoMenos10 = FxPlanejVenda.PplKgNacAnoMenos10(item);     // CD
                item.PplKgNacAnoMenos9 = FxPlanejVenda.PplKgNacAnoMenos9(item);     // CE
                item.PplKgNacAnoMenos8 = FxPlanejVenda.PplKgNacAnoMenos8(item);     // CF
                item.PplKgNacAnoMenos7 = FxPlanejVenda.PplKgNacAnoMenos7(item);     // CG
                item.PplKgNacAnoMenos6 = FxPlanejVenda.PplKgNacAnoMenos6(item);     // CH
                item.PplKgNacAnoMenos5 = FxPlanejVenda.PplKgNacAnoMenos5(item);     // CI
                item.PplKgNacAnoMenos4 = FxPlanejVenda.PplKgNacAnoMenos4(item);     // CJ
                item.PplKgNacAnoMenos3 = FxPlanejVenda.PplKgNacAnoMenos3(item);     // CK
                item.PplKgNacAnoMenos2 = FxPlanejVenda.PplKgNacAnoMenos2(item);     // CL
                item.PplKgNacAno = FxPlanejVenda.PplKgNacAno(item);     // CM
                item.PplKgNacTotal = FxPlanejVenda.PplKgNacTotal(item);     // CN
                item.PcbRbNacAnoMenos12 = FxPlanejVenda.PcbRbNacAnoMenos12(item);     // DA
                item.PcbRbNacAnoMenos11 = FxPlanejVenda.PcbRbNacAnoMenos11(item);     // DB
                item.PcbRbNacAnoMenos10 = FxPlanejVenda.PcbRbNacAnoMenos10(item);     // DC
                item.PcbRbNacAnoMenos9 = FxPlanejVenda.PcbRbNacAnoMenos9(item);     // DD
                item.PcbRbNacAnoMenos8 = FxPlanejVenda.PcbRbNacAnoMenos8(item);     // DE
                item.PcbRbNacAnoMenos7 = FxPlanejVenda.PcbRbNacAnoMenos7(item);     // DF
                item.PcbRbNacAnoMenos6 = FxPlanejVenda.PcbRbNacAnoMenos6(item);     // DG
                item.PcbRbNacAnoMenos5 = FxPlanejVenda.PcbRbNacAnoMenos5(item);     // DH
                item.PcbRbNacAnoMenos4 = FxPlanejVenda.PcbRbNacAnoMenos4(item);     // DI
                item.PcbRbNacAnoMenos3 = FxPlanejVenda.PcbRbNacAnoMenos3(item);     // DJ
                item.PcbRbNacAnoMenos2 = FxPlanejVenda.PcbRbNacAnoMenos2(item);     // DK
                item.PcbRbNacAno = FxPlanejVenda.PcbRbNacAnoMenos1(item);     // DL
                item.PcbRbNacTotal = FxPlanejVenda.PcbRbNacTotal(item);     // DM
                item.PipiIpiNacAnoMenos12 = FxPlanejVenda.PipiIpiNacAnoMenos12(item);     // DN
                item.PipiIpiNacAnoMenos11 = FxPlanejVenda.PipiIpiNacAnoMenos11(item);     // DO
                item.PipiIpiNacAnoMenos10 = FxPlanejVenda.PipiIpiNacAnoMenos10(item);     // DP
                item.PipiIpiNacAnoMenos9 = FxPlanejVenda.PipiIpiNacAnoMenos9(item);     // DQ
                item.PipiIpiNacAnoMenos8 = FxPlanejVenda.PipiIpiNacAnoMenos8(item);     // DR
                item.PipiIpiNacAnoMenos7 = FxPlanejVenda.PipiIpiNacAnoMenos7(item);     // DS
                item.PipiIpiNacAnoMenos6 = FxPlanejVenda.PipiIpiNacAnoMenos6(item);     // DT
                item.PipiIpiNacAnoMenos5 = FxPlanejVenda.PipiIpiNacAnoMenos5(item);     // DU
                item.PipiIpiNacAnoMenos4 = FxPlanejVenda.PipiIpiNacAnoMenos4(item);     // DV
                item.PipiIpiNacAnoMenos3 = FxPlanejVenda.PipiIpiNacAnoMenos3(item);     // DW
                item.PipiIpiNacAnoMenos2 = FxPlanejVenda.PipiIpiNacAnoMenos2(item);     // DX
                item.PipiIpiNacAno = FxPlanejVenda.PipiIpiNacAnoMenos1(item);     // DY
                item.PstStNacAnoMenos11 = FxPlanejVenda.PstStNacAnoMenos11(item);     // DZ
                item.PstStNacAnoMenos10 = FxPlanejVenda.PstStNacAnoMenos10(item);     // EA
                item.PstStNacAnoMenos09 = FxPlanejVenda.PstStNacAnoMenos9(item);     // EB
                item.PstStNacAnoMenos08 = FxPlanejVenda.PstStNacAnoMenos8(item);     // EC
                item.PstStNacAnoMenos07 = FxPlanejVenda.PstStNacAnoMenos7(item);     // ED
                item.PstStNacAnoMenos06 = FxPlanejVenda.PstStNacAnoMenos6(item);     // EE
                item.PstStNacAnoMenos05 = FxPlanejVenda.PstStNacAnoMenos5(item);     // EF
                item.PstStNacAnoMenos04 = FxPlanejVenda.PstStNacAnoMenos4(item);     // EG
                item.PstStNacAnoMenos03 = FxPlanejVenda.PstStNacAnoMenos3(item);     // EH
                item.PstStNacAnoMenos02 = FxPlanejVenda.PstStNacAnoMenos2(item);     // EI
                item.PstStNacAnoMenos01 = FxPlanejVenda.PstStNacAnoMenos1(item);     // EJ
                item.PstStNacAno00 = FxPlanejVenda.PstStNacAno(item);     // EK
                item.PfbFatBrAnoMenos12 = FxPlanejVenda.PfbFatBrAnoMenos12(item);     // EL
                item.PfbFatBrAnoMenos11 = FxPlanejVenda.PfbFatBrAnoMenos11(item);     // EM
                item.PfbFatBrAnoMenos10 = FxPlanejVenda.PfbFatBrAnoMenos10(item);     // EN
                item.PfbFatBrAnoMenos9 = FxPlanejVenda.PfbFatBrAnoMenos9(item);     // EO
                item.PfbFatBrAnoMenos8 = FxPlanejVenda.PfbFatBrAnoMenos8(item);     // EP
                item.PfbFatBrAnoMenos7 = FxPlanejVenda.PfbFatBrAnoMenos7(item);     // EQ
                item.PfbFatBrAnoMenos6 = FxPlanejVenda.PfbFatBrAnoMenos6(item);     // ER
                item.PfbFatBrAnoMenos5 = FxPlanejVenda.PfbFatBrAnoMenos5(item);     // ES
                item.PfbFatBrAnoMenos4 = FxPlanejVenda.PfbFatBrAnoMenos4(item);     // ET
                item.PfbFatBrAnoMenos3 = FxPlanejVenda.PfbFatBrAnoMenos3(item);     // EU
                item.PfbFatBrAnoMenos2 = FxPlanejVenda.PfbFatBrAnoMenos2(item);     // EV
                item.PfbFatBrAno = FxPlanejVenda.PfbFatBrAnoMenos1(item);     // EW
                item.PicmsIcmsNacAnoMenos12 = FxPlanejVenda.PicmsIcmsNacAnoMenos12(item);     // EX
                item.PicmsIcmsNacAnoMenos11 = FxPlanejVenda.PicmsIcmsNacAnoMenos11(item);     // EY
                item.PicmsIcmsNacAnoMenos10 = FxPlanejVenda.PicmsIcmsNacAnoMenos10(item);     // EZ
                item.PicmsIcmsNacAnoMenos9 = FxPlanejVenda.PicmsIcmsNacAnoMenos9(item);     // FA
                item.PicmsIcmsNacAnoMenos8 = FxPlanejVenda.PicmsIcmsNacAnoMenos8(item);     // FB
                item.PicmsIcmsNacAnoMenos7 = FxPlanejVenda.PicmsIcmsNacAnoMenos7(item);     // FC
                item.PicmsIcmsNacAnoMenos6 = FxPlanejVenda.PicmsIcmsNacAnoMenos6(item);     // FD
                item.PicmsIcmsNacAnoMenos5 = FxPlanejVenda.PicmsIcmsNacAnoMenos5(item);     // FE
                item.PicmsIcmsNacAnoMenos4 = FxPlanejVenda.PicmsIcmsNacAnoMenos4(item);     // FF
                item.PicmsIcmsNacAnoMenos3 = FxPlanejVenda.PicmsIcmsNacAnoMenos3(item);     // FG
                item.PicmsIcmsNacAnoMenos2 = FxPlanejVenda.PicmsIcmsNacAnoMenos2(item);     // FH
                item.PicmsIcmsNacAno = FxPlanejVenda.PicmsIcmsNacAnoMenos1(item);     // FI
                item.CrnFatBrutoNac = FxPlanejVenda.CrnFatBrutoNac(item);     // FJ
                item.CrnImpostos = FxPlanejVenda.CrnImpostos(item);     // FK
                item.CrnRecLiquidaNacional = FxPlanejVenda.CrnRecLiquidaNacional(item);     // FL
                item.CrnComissaoNac = FxPlanejVenda.CrnComissaoNac(item);     // FM
                item.CrnFreteNac = FxPlanejVenda.CrnFreteNac(item);     // FN
                item.CrnRecLiquidaVendaNac = FxPlanejVenda.CrnRecLiquidaVendaNac(item);     // FO
                item.CrnCustoDirMateriaisNac = FxPlanejVenda.CrnCustoDirMateriaisNac(item);     // FP
                item.CrnCustoDirModNac = FxPlanejVenda.CrnCustoDirModNac(item);     // FQ
                item.CrnFixoFabricaNac = FxPlanejVenda.CrnFixoFabricaNac(item);     // FR
                item.CrnMCNac = FxPlanejVenda.CrnMCNac(item);     // FS
                item.CrnMCNacPct = FxPlanejVenda.CrnMCNacPct(item);     // FT
                item.CrnCustoFixoAdmComNac = FxPlanejVenda.CrnCustoFixoAdmComNac(item);     // FU
                item.CrnResultadoBrutoNac = FxPlanejVenda.CrnResultadoBrutoNac(item);     // FV
                item.CrnResultadoBrutoNacPct = FxPlanejVenda.CrnResultadoBrutoNacPct(item);     // FW
                item.PqeQtExpAnoMenos12 = FxPlanejVenda.PqeQtExpAnoMenos12(item);     // GA
                item.PqeQtExpAnoMenos11 = FxPlanejVenda.PqeQtExpAnoMenos11(item);     // GB
                item.PqeQtExpAnoMenos10 = FxPlanejVenda.PqeQtExpAnoMenos10(item);     // GC
                item.PqeQtExpAnoMenos9 = FxPlanejVenda.PqeQtExpAnoMenos9(item);     // GD
                item.PqeQtExpAnoMenos8 = FxPlanejVenda.PqeQtExpAnoMenos8(item);     // GE
                item.PqeQtExpAnoMenos7 = FxPlanejVenda.PqeQtExpAnoMenos7(item);     // GF
                item.PqeQtExpAnoMenos6 = FxPlanejVenda.PqeQtExpAnoMenos6(item);     // GG
                item.PqeQtExpAnoMenos5 = FxPlanejVenda.PqeQtExpAnoMenos5(item);     // GH
                item.PqeQtExpAnoMenos4 = FxPlanejVenda.PqeQtExpAnoMenos4(item);     // GI
                item.PqeQtExpAnoMenos3 = FxPlanejVenda.PqeQtExpAnoMenos3(item);     // GJ
                item.PqeQtExpAnoMenos2 = FxPlanejVenda.PqeQtExpAnoMenos2(item);     // GK
                item.PqeQtExpAno = FxPlanejVenda.PqeQtExpAnoMenos1(item);     // GL
                item.PqeQtExpTotal = FxPlanejVenda.PqeQtExpTotal(item);     // GM
                item.PpleKgExpAnoMenos12 = FxPlanejVenda.PpleKgExpAnoMenos12(item);     // GN
                item.PpleKgExpAnoMenos11 = FxPlanejVenda.PpleKgExpAnoMenos11(item);     // GO
                item.PpleKgExpAnoMenos10 = FxPlanejVenda.PpleKgExpAnoMenos10(item);     // GP
                item.PpleKgExpAnoMenos9 = FxPlanejVenda.PpleKgExpAnoMenos9(item);     // GQ
                item.PpleKgExpAnoMenos8 = FxPlanejVenda.PpleKgExpAnoMenos8(item);     // GR
                item.PpleKgExpAnoMenos7 = FxPlanejVenda.PpleKgExpAnoMenos7(item);     // GS
                item.PpleKgExpAnoMenos6 = FxPlanejVenda.PpleKgExpAnoMenos9(item);     // GT
                item.PpleKgExpAnoMenos5 = FxPlanejVenda.PpleKgExpAnoMenos5(item);     // GU
                item.PpleKgExpAnoMenos4 = FxPlanejVenda.PpleKgExpAnoMenos4(item);     // GV
                item.PpleKgExpAnoMenos3 = FxPlanejVenda.PpleKgExpAnoMenos3(item);     // GW
                item.PpleKgExpAnoMenos2 = FxPlanejVenda.PpleKgExpAnoMenos2(item);     // GX
                item.PpleKgExpAno = FxPlanejVenda.PpleKgExpAnoMenos1(item);     // GY
                item.PpleKgExpTotal = FxPlanejVenda.PpleKgExpTotal(item);     // GZ
                item.PreUsdRcExpUsAnoMenos12 = FxPlanejVenda.PreUsdRcExpUsAnoMenos12(item);     // HM
                item.PreUsdRcExpUsAnoMenos11 = FxPlanejVenda.PreUsdRcExpUsAnoMenos11(item);     // HN
                item.PreUsdRcExpUsAnoMenos10 = FxPlanejVenda.PreUsdRcExpUsAnoMenos10(item);     // HO
                item.PreUsdRcExpUsAnoMenos9 = FxPlanejVenda.PreUsdRcExpUsAnoMenos9(item);     // HP
                item.PreUsdRcExpUsAnoMenos8 = FxPlanejVenda.PreUsdRcExpUsAnoMenos8(item);     // HQ
                item.PreUsdRcExpUsAnoMenos7 = FxPlanejVenda.PreUsdRcExpUsAnoMenos7(item);     // HR
                item.PreUsdRcExpUsAnoMenos6 = FxPlanejVenda.PreUsdRcExpUsAnoMenos6(item);     // HS
                item.PreUsdRcExpUsAnoMenos5 = FxPlanejVenda.PreUsdRcExpUsAnoMenos5(item);     // HT
                item.PreUsdRcExpUsAnoMenos4 = FxPlanejVenda.PreUsdRcExpUsAnoMenos4(item);     // HU
                item.PreUsdRcExpUsAnoMenos3 = FxPlanejVenda.PreUsdRcExpUsAnoMenos3(item);     // HV
                item.PreUsdRcExpUsAnoMenos2 = FxPlanejVenda.PreUsdRcExpUsAnoMenos2(item);     // HW
                item.PreUsdRcExpUsAno = FxPlanejVenda.PreUsdRcExpUsAnoMenos1(item);     // HX
                item.PreUsdRcExpUsRecExportUSD = FxPlanejVenda.PreUsdRcExpUsRecExportUSD(item);     // HY
                item.CreRecExportRs = FxPlanejVenda.CreRecExportRs(item);     // HZ
                item.CreComissaoExportRs = FxPlanejVenda.CreComissaoExportRs(item);     // IA
                item.CreFreteDespExportRs = FxPlanejVenda.CreFreteDespExportRs(item);     // IB *** Depende de contante hardcoded na planilha
                item.CreRecLiqVendaExportRs = FxPlanejVenda.CreRecLiqVendaExportRs(item);     // IC
                item.CreCustoDiretoMatModExptRs = FxPlanejVenda.CreCustoDiretoMatModExptRs(item);     // ID
                item.CreCustoFixoFabExpRs = FxPlanejVenda.CreCustoFixoFabExpRs(item);     // IE
                item.CreMCExportRs = FxPlanejVenda.CreMCExportRs(item);     // IF
                item.CreMCExportPct = FxPlanejVenda.CreMCExportPct(item);     // IG
                item.CreCustoFixoAdmComExpRs = FxPlanejVenda.CreCustoFixoAdmComExpRs(item);     // IH
                item.CreResultadoBrutoExpRs = FxPlanejVenda.CreResultadoBrutoExpRs(item);     // II
                item.CreResBrutoExpPct = FxPlanejVenda.CreResBrutoExpPct(item);     // IJ
                item.FbQuantTotal = FxPlanejVenda.FbQuantTotal(item);     // IK
                item.FbPesoTotal = FxPlanejVenda.FbPesoTotal(item);     // IL
                item.FbFaturamentoBrutoTotal = FxPlanejVenda.FbFaturamentoBrutoTotal(item);     // IM
                item.RlImpostoTotal = FxPlanejVenda.RlImpostoTotal(item);     // IN
                item.RlReceitaLiquidaTotal = FxPlanejVenda.RlReceitaLiquidaTotal(item);     // IO
                item.RlComissaoTotal = FxPlanejVenda.RlComissaoTotal(item);     // IP
                item.RlFreteDespExpTotal = FxPlanejVenda.RlFreteDespExpTotal(item);     // IQ
                item.RlRecLiqVendaTotal = FxPlanejVenda.RlRecLiqVendaTotal(item);     // IR
                item.McCustoDirMatModTotal = FxPlanejVenda.McCustoDirMatModTotal(item);     // IS
                item.McCustoFixoFabricaTotal = FxPlanejVenda.McCustoFixoFabricaTotal(item);     // IT
                item.McCustoFixoFabricaAjustado = FxPlanejVenda.McCustoFixoFabricaAjustado(item);     // IU
                item.McMargemContribTotal = FxPlanejVenda.McMargemContribTotal(item);     // IV
                item.McMCbTotalPct = FxPlanejVenda.McMCbTotalPct(item);     // IW
                
                item.CdTotAnoMenos12 = FxPlanejVenda.CdTotAnoMenos12(item);     // JB
                item.CdTotAnoMenos11 = FxPlanejVenda.CdTotAnoMenos11(item);     // JC
                item.CdTotAnoMenos10 = FxPlanejVenda.CdTotAnoMenos10(item);     // JD
                item.CdTotAnoMenos9 = FxPlanejVenda.CdTotAnoMenos9(item);     // JE
                item.CdTotAnoMenos8 = FxPlanejVenda.CdTotAnoMenos8(item);     // JF
                item.CdTotAnoMenos7 = FxPlanejVenda.CdTotAnoMenos7(item);     // JG
                item.CdTotAnoMenos6 = FxPlanejVenda.CdTotAnoMenos6(item);     // JH
                item.CdTotAnoMenos5 = FxPlanejVenda.CdTotAnoMenos5(item);     // JI
                item.CdTotAnoMenos4 = FxPlanejVenda.CdTotAnoMenos4(item);     // JJ
                item.CdTotAnoMenos3 = FxPlanejVenda.CdTotAnoMenos3(item);     // JK
                item.CdTotAnoMenos2 = FxPlanejVenda.CdTotAnoMenos2(item);     // JL
                item.CdTotAno = FxPlanejVenda.CdTotAnoMenos1(item);     // JM
                item.GifTotAnoMenos12 = FxPlanejVenda.GifTotAnoMenos12(item);     // JN
                item.GifTotAnoMenos11 = FxPlanejVenda.GifTotAnoMenos11(item);     // JO
                item.GifTotAnoMenos10 = FxPlanejVenda.GifTotAnoMenos10(item);     // JP
                item.GifTotAnoMenos9 = FxPlanejVenda.GifTotAnoMenos9(item);     // JQ
                item.GifTotAnoMenos8 = FxPlanejVenda.GifTotAnoMenos8(item);     // JR
                item.GifTotAnoMenos7 = FxPlanejVenda.GifTotAnoMenos7(item);     // JS
                item.GifTotAnoMenos6 = FxPlanejVenda.GifTotAnoMenos6(item);     // JT
                item.GifTotAnoMenos5 = FxPlanejVenda.GifTotAnoMenos5(item);     // JU
                item.GifTotAnoMenos4 = FxPlanejVenda.GifTotAnoMenos4(item);     // JV
                item.GifTotAnoMenos3 = FxPlanejVenda.GifTotAnoMenos3(item);     // JW
                item.GifTotAnoMenos2 = FxPlanejVenda.GifTotAnoMenos2(item);     // JX
                item.GifTotAno = FxPlanejVenda.GifTotAnoMenos1(item);     // JY
                item.ComTotAnoMenos12 = FxPlanejVenda.ComTotAnoMenos12(item);     // JZ
                item.ComTotAnoMenos11 = FxPlanejVenda.ComTotAnoMenos11(item);     // KA
                item.ComTotAnoMenos10 = FxPlanejVenda.ComTotAnoMenos10(item);     // KB
                item.ComTotAnoMenos9 = FxPlanejVenda.ComTotAnoMenos9(item);     // KC
                item.ComTotAnoMenos8 = FxPlanejVenda.ComTotAnoMenos8(item);     // KD
                item.ComTotAnoMenos7 = FxPlanejVenda.ComTotAnoMenos7(item);     // KE
                item.ComTotAnoMenos6 = FxPlanejVenda.ComTotAnoMenos6(item);     // KF
                item.ComTotAnoMenos5 = FxPlanejVenda.ComTotAnoMenos5(item);     // KG
                item.ComTotAnoMenos4 = FxPlanejVenda.ComTotAnoMenos4(item);     // KH
                item.ComTotAnoMenos3 = FxPlanejVenda.ComTotAnoMenos3(item);     // KI
                item.ComTotAnoMenos2 = FxPlanejVenda.ComTotAnoMenos2(item);     // KJ
                item.ComTotAno = FxPlanejVenda.ComTotAnoMenos1(item);     // KK
                item.FrtNacAnoMenos12 = FxPlanejVenda.FrtNacAnoMenos12(item);     // KL
                item.FrtNacAnoMenos11 = FxPlanejVenda.FrtNacAnoMenos11(item);     // KM
                item.FrtNacAnoMenos10 = FxPlanejVenda.FrtNacAnoMenos10(item);     // KN
                item.FrtNacAnoMenos9 = FxPlanejVenda.FrtNacAnoMenos9(item);     // KO
                item.FrtNacAnoMenos8 = FxPlanejVenda.FrtNacAnoMenos8(item);     // KP
                item.FrtNacAnoMenos7 = FxPlanejVenda.FrtNacAnoMenos7(item);     // KQ
                item.FrtNacAnoMenos6 = FxPlanejVenda.FrtNacAnoMenos6(item);     // KR
                item.FrtNacAnoMenos5 = FxPlanejVenda.FrtNacAnoMenos5(item);     // KS
                item.FrtNacAnoMenos4 = FxPlanejVenda.FrtNacAnoMenos4(item);     // KT
                item.FrtNacAnoMenos3 = FxPlanejVenda.FrtNacAnoMenos3(item);     // KU
                item.FrtNacAnoMenos2 = FxPlanejVenda.FrtNacAnoMenos2(item);     // KV
                item.FrtNacAno = FxPlanejVenda.FrtNacAnoMenos1(item);     // KW
                item.FrDexpAnoMenos12 = FxPlanejVenda.FrDexpAnoMenos12(item);     // KX
                item.FrDexpAnoMenos11 = FxPlanejVenda.FrDexpAnoMenos11(item);     // KY
                item.FrDexpAnoMenos10 = FxPlanejVenda.FrDexpAnoMenos10(item);     // KZ
                item.FrDexpAnoMenos9 = FxPlanejVenda.FrDexpAnoMenos9(item);     // LA
                item.FrDexpAnoMenos8 = FxPlanejVenda.FrDexpAnoMenos8(item);     // LB
                item.FrDexpAnoMenos7 = FxPlanejVenda.FrDexpAnoMenos7(item);     // LC
                item.FrDexpAnoMenos6 = FxPlanejVenda.FrDexpAnoMenos6(item);     // LD
                item.FrDexpAnoMenos5 = FxPlanejVenda.FrDexpAnoMenos5(item);     // LE
                item.FrDexpAnoMenos4 = FxPlanejVenda.FrDexpAnoMenos4(item);     // LF
                item.FrDexpAnoMenos3 = FxPlanejVenda.FrDexpAnoMenos3(item);     // LG
                item.FrDexpAnoMenos2 = FxPlanejVenda.FrDexpAnoMenos2(item);     // LH
                item.FrDexpAno = FxPlanejVenda.FrDexpAnoMenos1(item);     // LI
                item.CdsmtCfMatAnoMenos12 = FxPlanejVenda.CdsmtCfMatAnoMenos12(item);     // LJ
                item.CdsmtCfMatAnoMenos11 = FxPlanejVenda.CdsmtCfMatAnoMenos11(item);     // LK
                item.CdsmtCfMatAnoMenos10 = FxPlanejVenda.CdsmtCfMatAnoMenos10(item);     // LL
                item.CdsmtCfMatAnoMenos9 = FxPlanejVenda.CdsmtCfMatAnoMenos9(item);     // LM
                item.CdsmtCfMatAnoMenos8 = FxPlanejVenda.CdsmtCfMatAnoMenos8(item);     // LN
                item.CdsmtCfMatAnoMenos7 = FxPlanejVenda.CdsmtCfMatAnoMenos7(item);     // LO
                item.CdsmtCfMatAnoMenos6 = FxPlanejVenda.CdsmtCfMatAnoMenos6(item);     // LP
                item.CdsmtCfMatAnoMenos5 = FxPlanejVenda.CdsmtCfMatAnoMenos5(item);     // LQ
                item.CdsmtCfMatAnoMenos4 = FxPlanejVenda.CdsmtCfMatAnoMenos4(item);     // LR
                item.CdsmtCfMatAnoMenos3 = FxPlanejVenda.CdsmtCfMatAnoMenos3(item);     // LS
                item.CdsmtCfMatAnoMenos2 = FxPlanejVenda.CdsmtCfMatAnoMenos2(item);     // LT
                item.CdsmtCfMatAno = FxPlanejVenda.CdsmtCfMatAnoMenos1(item);     // LU
                item.QtvQtTottAnoMenos12 = FxPlanejVenda.QtvQtTottAnoMenos12(item);     // LV
                item.QtvQtTottAnoMenos11 = FxPlanejVenda.QtvQtTottAnoMenos11(item);     // LW
                item.QtvQtTottAnoMenos10 = FxPlanejVenda.QtvQtTottAnoMenos10(item);     // LX
                item.QtvQtTottAnoMenos9 = FxPlanejVenda.QtvQtTottAnoMenos9(item);     // LY
                item.QtvQtTottAnoMenos8 = FxPlanejVenda.QtvQtTottAnoMenos8(item);     // LZ
                item.QtvQtTottAnoMenos7 = FxPlanejVenda.QtvQtTottAnoMenos7(item);     // MA
                item.QtvQtTottAnoMenos6 = FxPlanejVenda.QtvQtTottAnoMenos6(item);     // MB
                item.QtvQtTottAnoMenos5 = FxPlanejVenda.QtvQtTottAnoMenos5(item);     // MC
                item.QtvQtTottAnoMenos4 = FxPlanejVenda.QtvQtTottAnoMenos4(item);     // MD
                item.QtvQtTottAnoMenos3 = FxPlanejVenda.QtvQtTottAnoMenos3(item);     // ME
                item.QtvQtTottAnoMenos2 = FxPlanejVenda.QtvQtTottAnoMenos2(item);     // MF
                item.QtvQtTottAno = FxPlanejVenda.QtvQtTottAnoMenos1(item);     // MG
                item.HorasProdAnoMenos12 = FxPlanejVenda.HorasProdAnoMenos12(item);     // MH
                item.HorasProdAnoMenos11 = FxPlanejVenda.HorasProdAnoMenos11(item);     // MI
                item.HorasProdAnoMenos10 = FxPlanejVenda.HorasProdAnoMenos10(item);     // MJ
                item.HorasProdAnoMenos9 = FxPlanejVenda.HorasProdAnoMenos9(item);     // MK
                item.HorasProdAnoMenos8 = FxPlanejVenda.HorasProdAnoMenos8(item);     // ML
                item.HorasProdAnoMenos7 = FxPlanejVenda.HorasProdAnoMenos7(item);     // MM
                item.HorasProdAnoMenos6 = FxPlanejVenda.HorasProdAnoMenos6(item);     // MN
                item.HorasProdAnoMenos5 = FxPlanejVenda.HorasProdAnoMenos5(item);     // MO
                item.HorasProdAnoMenos4 = FxPlanejVenda.HorasProdAnoMenos4(item);     // MP
                item.HorasProdAnoMenos3 = FxPlanejVenda.HorasProdAnoMenos3(item);     // MQ
                item.HorasProdAnoMenos2 = FxPlanejVenda.HorasProdAnoMenos2(item);     // MR
                item.HorasProdAno = FxPlanejVenda.HorasProdAnoMenos1(item);     // MS
                item.HorasProdTotal = FxPlanejVenda.HorasProdTotal(item);     // MT
                item.RecNacAnoMenos12 = FxPlanejVenda.RecNacAnoMenos12(item);     // MU
                item.RecNacAnoMenos11 = FxPlanejVenda.RecNacAnoMenos11(item);     // MV
                item.RecNacAnoMenos10 = FxPlanejVenda.RecNacAnoMenos10(item);     // MW
                item.RecNacAnoMenos9 = FxPlanejVenda.RecNacAnoMenos9(item);     // MX
                item.RecNacAnoMenos8 = FxPlanejVenda.RecNacAnoMenos8(item);     // MY
                item.RecNacAnoMenos7 = FxPlanejVenda.RecNacAnoMenos7(item);     // MZ
                item.RecNacAnoMenos6 = FxPlanejVenda.RecNacAnoMenos6(item);     // NA
                item.RecNacAnoMenos5 = FxPlanejVenda.RecNacAnoMenos5(item);     // NB
                item.RecNacAnoMenos4 = FxPlanejVenda.RecNacAnoMenos4(item);     // NC
                item.RecNacAnoMenos3 = FxPlanejVenda.RecNacAnoMenos3(item);     // ND
                item.RecNacAnoMenos2 = FxPlanejVenda.RecNacAnoMenos2(item);     // NE
                item.RecNacAno = FxPlanejVenda.RecNacAnoMenos1(item);     // NF
                item.RecExpAnoMenos12 = FxPlanejVenda.RecExpAnoMenos12(item);     // NG
                item.RecExpAnoMenos11 = FxPlanejVenda.RecExpAnoMenos11(item);     // NH
                item.RecExpAnoMenos10 = FxPlanejVenda.RecExpAnoMenos10(item);     // NI
                item.RecExpAnoMenos9 = FxPlanejVenda.RecExpAnoMenos9(item);     // NJ
                item.RecExpAnoMenos8 = FxPlanejVenda.RecExpAnoMenos8(item);     // NK
                item.RecExpAnoMenos7 = FxPlanejVenda.RecExpAnoMenos7(item);     // NL
                item.RecExpAnoMenos6 = FxPlanejVenda.RecExpAnoMenos6(item);     // NM
                item.RecExpAnoMenos5 = FxPlanejVenda.RecExpAnoMenos5(item);     // NN
                item.RecExpAnoMenos4 = FxPlanejVenda.RecExpAnoMenos4(item);     // NO
                item.RecExpAnoMenos3 = FxPlanejVenda.RecExpAnoMenos3(item);     // NP
                item.RecExpAnoMenos2 = FxPlanejVenda.RecExpAnoMenos2(item);     // NQ
                item.RecExpAno = FxPlanejVenda.RecExpAnoMenos1(item);     // NR
            }

            foreach (var item in model)
            {
                item.RoCustoFixoComAdmTotal = FxPlanejVenda.RoCustoFixoComAdmTotal(item);     // IX
                item.RoCustoFixoComAdmAjustadoTotal = FxPlanejVenda.RoCustoFixoComAdmAjustadoTotal(item);     // IY
                item.RoResultadoOperacionalTotal = FxPlanejVenda.RoCustoFixoComAdmTotal(item);     // IZ
                item.RoResultadoOperacionalTotalPct = FxPlanejVenda.RoResultadoOperacionalTotalPct(item);     // JA
            }

            db.SaveChanges();
        }
    }
}