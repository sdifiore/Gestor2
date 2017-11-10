using System;
using System.Data.Entity;
using System.Diagnostics;
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
                register.UnidadeCompraId = FxEstrutura.UnidadeCompraId(register);    // H
                register.CustoUnitCompra = FxEstrutura.CustoUnitCompra(register);   // I
                register.QtEftvUntrCmpnt = FxEstrutura.QtEftvUntrCmpnt(register);   // O
                register.CstCmprUndPrd = FxEstrutura.CstCmprUndPrd(register);   // P
                register.PartCusto = FxEstrutura.PartCusto(register);   // N
                register.TempMaq = FxEstrutura.TempMaq(register);   // S
                register.QtdUndd = register.Produto.QtUnPorUnArmz;  // T
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
                register.CustoFixoTotal = FxProduto.CustoFixoTotal(register);       // Planilha 2, S -- Fazer
                register.MoiFabricacao = FxProduto.MoiFabricacao(register);     // T -- Fazer

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
    }
}