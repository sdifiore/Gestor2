using Gestor.Models;
using System;
using System.Linq;

namespace Gestor
{
    public static class FxPlanejVenda
    {
        public static float PesoUnitario(PlanejVenda planej)        // G
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == planej.ProdutoId);
            if (produto != null) result = produto.PesoLiquido;
            else DbLogger.Log(Reason.Info, $"Produto Id {planej.ProdutoId} não encontrado em PlanejVendas.PesoUniario");

            return result;
        }

        public static float HorasMod(PlanejVenda planej)        // H
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == planej.ProdutoId);
            if (produto != null) result = produto.HorasModTotal;
            else DbLogger.Log(Reason.Info, $"Produto Id {planej.ProdutoId} não encontrado em PlanejVendas.HorasMod");

            return result;
        }

        public static float CustoDiretoTotal(PlanejVenda planej)        // I
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == planej.ProdutoId);
            if (produto != null) result = produto.CustODirTotal;
            else DbLogger.Log(Reason.Info, $"Produto Id {planej.ProdutoId} não encontrado em PlanejVendas.CustoDiretoTotal");

            return result;
        }

        public static float CustoDiretoMats(PlanejVenda planej)        // J
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == planej.ProdutoId);
            if (produto != null) result = produto.CstTotMaterial;
            else DbLogger.Log(Reason.Info, $"Produto Id {planej.ProdutoId} não encontrado em PlanejVendas.CustoDiretoMats");

            return result;
        }

        public static float CustoDiretoMod(PlanejVenda planej)        // K
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == planej.ProdutoId);
            if (produto != null) result = produto.CustoDirMod;
            else DbLogger.Log(Reason.Info, $"Produto Id {planej.ProdutoId} não encontrado em PlanejVendas.CustoDiretoMod");

            return result;
        }

        public static float CustoFixoFabrica(PlanejVenda planej)        // L
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == planej.ProdutoId);
            if (produto != null) result = produto.MoiFabricAnr + produto.OutrosCustosFab;
            else DbLogger.Log(Reason.Info, $"Produto Id {planej.ProdutoId} não encontrado em PlanejVendas.CustoFixoFabrica");

            return result;
        }

        public static float CustoFixAdmCom(PlanejVenda planej)        // M
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == planej.ProdutoId);
            if (produto != null) result = produto.CustoFixoComacsCmtexAnr + produto.CustoFixoAdminAnr;
            else DbLogger.Log(Reason.Info, $"Produto Id {planej.ProdutoId} não encontrado em PlanejVendas.CustoFixAdmCom");

            return result;
        }

        public static float AliquotaIpi(PlanejVenda planej)        // O
        {
            float result = 0;
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == planej.ProdutoId);
            if (produto != null) result = produto.Ipi;
            else DbLogger.Log(Reason.Info, $"Produto Id {planej.ProdutoId} não encontrado em PlanejVendas.AliquotaIpi");

            return result;
        }

        public static float QvQtNacAnoMenos11(PlanejVenda planej)       // P
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos11), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos10(PlanejVenda planej)       // Q
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos10), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos9(PlanejVenda planej)       // R
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos09), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos8(PlanejVenda planej)       // S
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos08), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos7(PlanejVenda planej)       // T
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos07), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos6(PlanejVenda planej)       // U
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos06), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos5(PlanejVenda planej)       // V
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos05), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos4(PlanejVenda planej)       // W
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos04), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos3(PlanejVenda planej)       // X
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos03), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos2(PlanejVenda planej)       // Y
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos02), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAnoMenos1(PlanejVenda planej)       // Z
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos01), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QvQtNacAno(PlanejVenda planej)       // AA
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAno00), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtNacMediaMensal(PlanejVenda planej)        // AB
        {
            return (planej.QvQtNacAnoMenos01 + planej.QvQtNacAnoMenos11 + planej.QvQtNacAnoMenos10 + planej.QvQtNacAnoMenos09 +
                planej.QvQtNacAnoMenos08 + planej.QvQtNacAnoMenos07 + planej.QvQtNacAnoMenos06 + planej.QvQtNacAnoMenos05 +
                planej.QvQtNacAnoMenos04 + planej.QvQtNacAnoMenos03 + planej.QvQtNacAnoMenos02 + planej.QvQtNacAno00) / 12;
        }

        public static float PvMed1o3m(PlanejVenda planej)       // AC
        {
            float a = 0;
            float b = 0;
            float c = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos11), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) a = fatHistorico.Sum(f => f.RecBruta);

            anoMes = AnoMes(nameof(planej.PstStNacAnoMenos10), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) b = fatHistorico.Sum(f => f.RecBruta);

            anoMes = AnoMes(nameof(planej.PstStNacAnoMenos09), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) c = fatHistorico.Sum(f => f.RecBruta);

            var d = planej.QvQtNacAnoMenos11 + planej.QvQtNacAnoMenos10 + planej.QvQtNacAnoMenos09;

            var result = Math.Abs(d) > Global.Tolerance
                            ? (a + b + c) / d
                            : 0;

            return result;
        }

        public static float PvMed2o3m(PlanejVenda planej)       // AD
        {
            float a = 0;
            float b = 0;
            float c = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos08), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) a = fatHistorico.Sum(f => f.RecBruta);

            anoMes = AnoMes(nameof(planej.PstStNacAnoMenos07), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) b = fatHistorico.Sum(f => f.RecBruta);

            anoMes = AnoMes(nameof(planej.PstStNacAnoMenos06), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) c = fatHistorico.Sum(f => f.RecBruta);

            var d = planej.QvQtNacAnoMenos08 + planej.QvQtNacAnoMenos07 + planej.QvQtNacAnoMenos06;

            var result = Math.Abs(d) > Global.Tolerance
                            ? (a + b + c) / d
                            : 0;

            return result;
        }

        public static float PvMed3o3m(PlanejVenda planej)       // AE
        {
            float a = 0;
            float b = 0;
            float c = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos05), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) a = fatHistorico.Sum(f => f.RecBruta);

            anoMes = AnoMes(nameof(planej.PstStNacAnoMenos04), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) b = fatHistorico.Sum(f => f.RecBruta);

            anoMes = AnoMes(nameof(planej.PstStNacAnoMenos03), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) c = fatHistorico.Sum(f => f.RecBruta);

            var d = planej.QvQtNacAnoMenos05 + planej.QvQtNacAnoMenos04 + planej.QvQtNacAnoMenos03;

            var result = Math.Abs(d) > Global.Tolerance
                ? (a + b + c) / d
                : 0;

            return result;
        }

        public static float PvMed4o3m(PlanejVenda planej)       // AF
        {
            float a = 0;
            float b = 0;
            float c = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");
            string anoMes = AnoMes(nameof(planej.PstStNacAnoMenos02), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) a = fatHistorico.Sum(f => f.RecBruta);

            anoMes = AnoMes(nameof(planej.PstStNacAnoMenos01), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) b = fatHistorico.Sum(f => f.RecBruta);

            anoMes = AnoMes(nameof(planej.PstStNacAno00), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) c = fatHistorico.Sum(f => f.RecBruta);

            var d = planej.QvQtNacAnoMenos02 + planej.QvQtNacAnoMenos01 + planej.QvQtNacAno00;

            var result = Math.Abs(d) > Global.Tolerance
                ? (a + b + c) / d
                : 0;

            return result;
        }

        public static float PvNacAdotado(PlanejVenda planej)        // AG
        {
            float result = planej.PvMed4o3m;

            if (Math.Abs(result) < Global.Tolerance)
            {
                int countif = 0;
                if (Math.Abs(planej.PvMed1o3m) > Global.Tolerance) countif++;
                if (Math.Abs(planej.PvMed2o3m) > Global.Tolerance) countif++;
                if (Math.Abs(planej.PvMed3o3m) > Global.Tolerance) countif++;
                if (Math.Abs(planej.PvMed4o3m) > Global.Tolerance) countif++;
                float soma = planej.PvMed1o3m + planej.PvMed2o3m + planej.PvMed3o3m + planej.PvMed4o3m;
                result = countif > 0
                    ? soma / countif
                    : 0;
            }

            return result;
        }

        public static float StMedia(PlanejVenda planej)     // AH
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");

            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda);
            if (fatHistorico.Any())
            {
                float a = fatHistorico.Sum(f => f.ValorSubstTributaria);
                float b = fatHistorico.Sum(f => f.ValorMercadoria);
                if (Math.Abs(b) > Global.Tolerance) result = a / b;
            }

            return result;
        }

        public static float IcmsMedio(PlanejVenda planej)       // AI
        {
            float result = 0;

            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");

            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda);
            if (fatHistorico.Any())
            {
                float a = fatHistorico.Sum(f => f.Icms);
                float b = fatHistorico.Sum(f => f.ValorMercadoria);
                if (Math.Abs(b) > Global.Tolerance) result = a / b;
            }

            return result;
        }

        public static float ComissaoMediaNac(PlanejVenda planej)       // AJ
        {
            float result = 0;

            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");

            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda);
            if (fatHistorico.Any())
            {
                float a = fatHistorico.Sum(f => f.Comissao);
                float b = fatHistorico.Sum(f => f.ComGvComacs);
                float c = fatHistorico.Sum(f => f.RecBruta);
                if (Math.Abs(b) > Global.Tolerance) result = (a + b) / c;
            }

            return result;
        }

        public static float FreteNacPct(PlanejVenda planej)       // AK
        {
            float result = 0;

            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");

            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda);
            if (fatHistorico.Any())
            {
                float a = fatHistorico.Sum(f => f.Frete);
                float b = fatHistorico.Sum(f => f.FaturBruto);
                if (Math.Abs(b) > Global.Tolerance) result = a / b;
            }

            return result;
        }

        public static float PrazoRecebMedioNac(PlanejVenda planej)       // AL
        {
            float result = 0;

            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaNacional");

            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda);
            if (fatHistorico.Any())
            {
                float a = fatHistorico.Sum(f => f.PrazoFatur);
                float b = fatHistorico.Sum(f => f.FaturBruto);
                if (Math.Abs(b) > Global.Tolerance) result = a / b;
            }

            return result;
        }

        public static int MesRecebMedNac(PlanejVenda planej)      // AM
        {
            int result = (int)Math.Truncate((15 + planej.PrazoRecebMedioNac) / 30);

            return result;
        }

        public static float QtExpAnoMenos11(PlanejVenda planej)       // AN
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos11), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos10(PlanejVenda planej)       // AO
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos10), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos09(PlanejVenda planej)       // AP
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos09), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos08(PlanejVenda planej)       // AQ
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos08), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos07(PlanejVenda planej)       // AR
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos07), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos06(PlanejVenda planej)       // AS
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos06), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos05(PlanejVenda planej)       // AT
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos05), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos04(PlanejVenda planej)       // AU
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos04), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos03(PlanejVenda planej)       // AV
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos03), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos02(PlanejVenda planej)       // AW
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos02), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAnoMenos01(PlanejVenda planej)       // AX
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAnoMenos01), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpAno00(PlanejVenda planej)       // AY
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QtExpAno00), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) result = fatHistorico.Sum(f => f.QuantAjustada);

            return result;
        }

        public static float QtExpMediaMensal(PlanejVenda planej)        // AZ
        {
            float result = (planej.QtExpAnoMenos01 + planej.QtExpAnoMenos02 + planej.QtExpAnoMenos03 +
                planej.QtExpAnoMenos04 + planej.QtExpAnoMenos05 + planej.QtExpAnoMenos06 + planej.QtExpAnoMenos07 +
                planej.QtExpAnoMenos08 + planej.QtExpAnoMenos09 + planej.QtExpAnoMenos10 + planej.QtExpAnoMenos11 +
                planej.QtExpAno00) / 12;

            return result;
        }

        public static float PvMedEx1o3m(PlanejVenda planej)       // BA
        {
            float a = 0;
            float b = 0;
            float c = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos11), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) a = fatHistorico.Sum(f => f.FatBrutoUsd);

            anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos10), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) b = fatHistorico.Sum(f => f.FatBrutoUsd);

            anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos09), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) c = fatHistorico.Sum(f => f.FatBrutoUsd);

            var d = planej.QtExpAnoMenos11 + planej.QtExpAnoMenos10 + planej.QtExpAnoMenos09;

            var result = Math.Abs(d) > Global.Tolerance
                            ? (a + b + c) / d
                            : 0;

            return result;
        }

        public static float PvMedEx2o3m(PlanejVenda planej)       // BB
        {
            float a = 0;
            float b = 0;
            float c = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos08), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) a = fatHistorico.Sum(f => f.FatBrutoUsd);

            anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos07), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) b = fatHistorico.Sum(f => f.FatBrutoUsd);

            anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos06), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) c = fatHistorico.Sum(f => f.FatBrutoUsd);

            var d = planej.QtExpAnoMenos08 + planej.QtExpAnoMenos07 + planej.QtExpAnoMenos06;

            var result = Math.Abs(d) > Global.Tolerance
                            ? (a + b + c) / d
                            : 0;

            return result;
        }

        public static float PvMedEx3o3m(PlanejVenda planej)       // BC
        {
            float a = 0;
            float b = 0;
            float c = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos05), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) a = fatHistorico.Sum(f => f.FatBrutoUsd);

            anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos04), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) b = fatHistorico.Sum(f => f.FatBrutoUsd);

            anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos03), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) c = fatHistorico.Sum(f => f.FatBrutoUsd);

            var d = planej.QtExpAnoMenos05 + planej.QtExpAnoMenos04 + planej.QtExpAnoMenos03;

            var result = Math.Abs(d) > Global.Tolerance
                            ? (a + b + c) / d
                            : 0;

            return result;
        }

        public static float PvMedEx4o3m(PlanejVenda planej)       // BD
        {
            float a = 0;
            float b = 0;
            float c = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            string anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos02), planej.RefAno);
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda
                                                        && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) a = fatHistorico.Sum(f => f.FatBrutoUsd);

            anoMes = AnoMes(nameof(planej.QvQtNacAnoMenos01), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) b = fatHistorico.Sum(f => f.FatBrutoUsd);

            anoMes = AnoMes(nameof(planej.QvQtNacAno00), planej.RefAno);
            fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                    && f.TipoVenda == tipoVenda
                                                    && f.AnoMesFatura == anoMes);
            if (fatHistorico.Any()) c = fatHistorico.Sum(f => f.FatBrutoUsd);

            var d = planej.QtExpAnoMenos02 + planej.QtExpAnoMenos01 + planej.QtExpAno00;

            var result = Math.Abs(d) > Global.Tolerance
                            ? (a + b + c) / d
                            : 0;

            return result;
        }

        public static float PvMedExAdotado(PlanejVenda planej)      // BE
        {
            int countif = 0;
            if (Math.Abs(planej.PvMedEx1o3m) > Global.Tolerance) countif++;
            if (Math.Abs(planej.PvMedEx2o3m) > Global.Tolerance) countif++;
            if (Math.Abs(planej.PvMedEx3o3m) > Global.Tolerance) countif++;
            if (Math.Abs(planej.PvMedEx4o3m) > Global.Tolerance) countif++;

            float result = countif > 0
                ? (planej.PvMedEx1o3m + planej.PvMedEx2o3m + planej.PvMedEx3o3m + planej.PvMedEx4o3m) / countif
                : 0;

            return result;
        }

        public static float ComissaoExpPct(PlanejVenda planej)      // BF
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            var fatHistorico = db.FatHistoricos.FirstOrDefault(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda);
            if (fatHistorico != null)
            {
                float a = fatHistorico.Comissao;
                float b = fatHistorico.RecBruta;
                if (Math.Abs(b) > Global.Tolerance) result = a / b;
            }

            return result;
        }

        public static int PrazoRecebMedExp(PlanejVenda planej)      // BG
        {
            int result = 0;
            var db = new ApplicationDbContext();
            string tipoVenda = XmlReader.Read("TipoVendaExportacao");
            var fatHistorico = db.FatHistoricos.Where(f => f.ProdutoAjustadoId == planej.ProdutoId
                                                        && f.TipoVenda == tipoVenda).ToList();
            if (fatHistorico != null)
            {
                float a = fatHistorico.Sum(f => f.PrazoFatur);
                float b = fatHistorico.Sum(f => f.FaturBruto);
                if (Math.Abs(b) > Global.Tolerance) result = (int)(a / b);
            }

            return result;
        }

        public static int MesRecebMedExp(PlanejVenda planej)      // BH
        {
            int result = ((15 + planej.PrazoRecebMedExp) / 30);

            return result;
        }

        public static float PqQtNacAnoMenos11(PlanejVenda planej)       //BO
        {
            float result = 0;
            double intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    float a = planej.QvQtNacAnoMenos11 + planej.QvQtNacAnoMenos10 + planej.QvQtNacAnoMenos09;
                    float b = 1 + planej.VartC1 / 100f;
                    intermediate = a / 3f * b;
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos11 * (1 + planej.VartC1 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos10(PlanejVenda planej)       //BP
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos11 + planej.QvQtNacAnoMenos10 + planej.QvQtNacAnoMenos09) / 3f *
                        (1 + planej.VartC1 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos10 * (1 + planej.VartC1 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos09(PlanejVenda planej)       //BQ
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos11 + planej.QvQtNacAnoMenos10 + planej.QvQtNacAnoMenos09) / 3f *
                        (1 + planej.VartC1 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos09 * (1 + planej.VartC1 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos08(PlanejVenda planej)       //BR
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos08 + planej.QvQtNacAnoMenos07 + planej.QvQtNacAnoMenos06) / 3f *
                        (1 + planej.VarTc2 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos08 * (1 + planej.VarTc2 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos07(PlanejVenda planej)       //BS
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos08 + planej.QvQtNacAnoMenos07 + planej.QvQtNacAnoMenos06) / 3f *
                        (1 + planej.VarTc2 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos07 * (1 + planej.VarTc2 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos06(PlanejVenda planej)       //BT
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos08 + planej.QvQtNacAnoMenos07 + planej.QvQtNacAnoMenos06) / 3f *
                        (1 + planej.VarTc2 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos06 * (1 + planej.VarTc2 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos05(PlanejVenda planej)       //BU
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos05 + planej.QvQtNacAnoMenos04 + planej.QvQtNacAnoMenos03) / 3f *
                        (1 + planej.VartC3 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos05 * (1 + planej.VartC3 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos04(PlanejVenda planej)       //BV
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos05 + planej.QvQtNacAnoMenos04 + planej.QvQtNacAnoMenos03) / 3f *
                        (1 + planej.VartC3 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos04 * (1 + planej.VartC3 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos03(PlanejVenda planej)       //BW
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos05 + planej.QvQtNacAnoMenos04 + planej.QvQtNacAnoMenos03) / 3f *
                        (1 + planej.VartC3 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos03 * (1 + planej.VartC3 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos02(PlanejVenda planej)       //BX
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos02 + planej.QvQtNacAnoMenos01 + planej.QvQtNacAno00) / 3f *
                        (1 + planej.VartC4 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos02 * (1 + planej.VartC4 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAnoMenos01(PlanejVenda planej)       //BY
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos02 + planej.QvQtNacAnoMenos01 + planej.QvQtNacAno00) / 3f *
                        (1 + planej.VartC4 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAnoMenos01 * (1 + planej.VartC4 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacAno00(PlanejVenda planej)       //BZ
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m")
                {
                    intermediate = (planej.QvQtNacAnoMenos02 + planej.QvQtNacAnoMenos01 + planej.QvQtNacAno00) / 3f *
                        (1 + planej.VartC4 / 100f);
                }

                else
                {
                    intermediate = planej.PqQtNacAno00 * (1 + planej.VartC4 / 100f);
                }
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $B$U2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqQtNacTotal(PlanejVenda planej)        // CA
        {
            return planej.PqQtNacAnoMenos01 + planej.PqQtNacAnoMenos02 + planej.PqQtNacAnoMenos03 + planej.PqQtNacAnoMenos04 +
                planej.PqQtNacAnoMenos05 + planej.PqQtNacAnoMenos06 + planej.PqQtNacAnoMenos07 + planej.PqQtNacAnoMenos08 +
                planej.PqQtNacAnoMenos09 + planej.PqQtNacAnoMenos10 + planej.PqQtNacAnoMenos11 + planej.PqQtNacAno00;
        }

        public static float PplKgNacAnoMenos12(PlanejVenda planej)      // CB
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos11;
        }

        public static float PplKgNacAnoMenos11(PlanejVenda planej)      // CC
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos10;
        }

        public static float PplKgNacAnoMenos10(PlanejVenda planej)      // CD
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos09;
        }

        public static float PplKgNacAnoMenos9(PlanejVenda planej)      // CE
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos08;
        }

        public static float PplKgNacAnoMenos8(PlanejVenda planej)      // CF
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos07;
        }

        public static float PplKgNacAnoMenos7(PlanejVenda planej)      // CG
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos06;
        }

        public static float PplKgNacAnoMenos6(PlanejVenda planej)      // CH
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos05;
        }

        public static float PplKgNacAnoMenos5(PlanejVenda planej)      // CI
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos04;
        }

        public static float PplKgNacAnoMenos4(PlanejVenda planej)      // CJ
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos03;
        }

        public static float PplKgNacAnoMenos3(PlanejVenda planej)      // CL
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos02;
        }

        public static float PplKgNacAnoMenos2(PlanejVenda planej)      // CL
        {
            return planej.PesoUnitario * planej.PqQtNacAnoMenos01;
        }

        public static float PplKgNacAno(PlanejVenda planej)      // CM
        {
            return planej.PesoUnitario * planej.PqQtNacAno00;
        }

        public static float PplKgNacTotal(PlanejVenda planej)       // CN
        {
            return planej.PplKgNacAnoMenos12 + planej.PplKgNacAnoMenos11 + planej.PplKgNacAnoMenos10 + planej.PplKgNacAnoMenos9 +
                planej.PplKgNacAnoMenos8 + planej.PplKgNacAnoMenos7 + planej.PplKgNacAnoMenos6 + planej.PplKgNacAnoMenos5 + planej.PplKgNacAnoMenos4 +
                planej.PplKgNacAnoMenos3 + planej.PplKgNacAnoMenos2 + planej.PplKgNacAno;
        }

        public static float PcbRbNacAnoMenos12(PlanejVenda planej)      // DA
        {
            return planej.PqQtNacAnoMenos11 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos12);
        }

        public static float PcbRbNacAnoMenos11(PlanejVenda planej)      // DB
        {
            return planej.PqQtNacAnoMenos10 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos11);
        }

        public static float PcbRbNacAnoMenos10(PlanejVenda planej)      // DC
        {
            return planej.PqQtNacAnoMenos09 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos10);
        }

        public static float PcbRbNacAnoMenos9(PlanejVenda planej)      // DD
        {
            return planej.PqQtNacAnoMenos08 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos9);
        }

        public static float PcbRbNacAnoMenos8(PlanejVenda planej)      // DE
        {
            return planej.PqQtNacAnoMenos07 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos8);
        }

        public static float PcbRbNacAnoMenos7(PlanejVenda planej)      // DF
        {
            return planej.PqQtNacAnoMenos06 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos7);
        }

        public static float PcbRbNacAnoMenos6(PlanejVenda planej)      // DG
        {
            return planej.PqQtNacAnoMenos05 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos6);
        }

        public static float PcbRbNacAnoMenos5(PlanejVenda planej)      // DH
        {
            return planej.PqQtNacAnoMenos04 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos5);
        }

        public static float PcbRbNacAnoMenos4(PlanejVenda planej)      // DI
        {
            return planej.PqQtNacAnoMenos03 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos4);
        }

        public static float PcbRbNacAnoMenos3(PlanejVenda planej)      // DJ
        {
            return planej.PqQtNacAnoMenos02 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos3);
        }

        public static float PcbRbNacAnoMenos2(PlanejVenda planej)      // DK
        {
            return planej.PqQtNacAnoMenos01 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAnoMenos2);
        }

        public static float PcbRbNacAnoMenos1(PlanejVenda planej)      // DL
        {
            return planej.PqQtNacAno00 * planej.PvNacAdotado * (1 + planej.PvvpvaVarPvAno);
        }

        public static float PcbRbNacTotal(PlanejVenda planej)       // DM
        {
            return planej.PcbRbNacAno + planej.PcbRbNacAnoMenos2 + planej.PcbRbNacAnoMenos3 + planej.PcbRbNacAnoMenos4 +
                planej.PcbRbNacAnoMenos5 + planej.PcbRbNacAnoMenos6 + planej.PcbRbNacAnoMenos7 + planej.PcbRbNacAnoMenos8 + planej.PcbRbNacAnoMenos9 +
                planej.PcbRbNacAnoMenos10 + planej.PcbRbNacAnoMenos11 + planej.PcbRbNacAnoMenos12;
        }

        public static float PipiIpiNacAnoMenos12(PlanejVenda planej)        // DN
        {
            return planej.PcbRbNacAnoMenos12 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos11(PlanejVenda planej)        // DO
        {
            return planej.PcbRbNacAnoMenos11 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos10(PlanejVenda planej)        // DP
        {
            return planej.PcbRbNacAnoMenos10 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos9(PlanejVenda planej)        // DQ
        {
            return planej.PcbRbNacAnoMenos9 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos8(PlanejVenda planej)        // DR
        {
            return planej.PcbRbNacAnoMenos8 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos7(PlanejVenda planej)        // DS
        {
            return planej.PcbRbNacAnoMenos7 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos6(PlanejVenda planej)        // DT
        {
            return planej.PcbRbNacAnoMenos6 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos5(PlanejVenda planej)        // DU
        {
            return planej.PcbRbNacAnoMenos5 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos4(PlanejVenda planej)        // DV
        {
            return planej.PcbRbNacAnoMenos4 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos3(PlanejVenda planej)        // DW
        {
            return planej.PcbRbNacAnoMenos3 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos2(PlanejVenda planej)        // DX
        {
            return planej.PcbRbNacAnoMenos2 * planej.AliquotaIpi;
        }

        public static float PipiIpiNacAnoMenos1(PlanejVenda planej)        // DY
        {
            return planej.PcbRbNacAno * planej.AliquotaIpi;
        }

        public static float PstStNacAnoMenos11(PlanejVenda planej)      // DZ
        {
            return planej.PcbRbNacAnoMenos12 * planej.StMedia;
        }

        public static float PstStNacAnoMenos10(PlanejVenda planej)      // EA
        {
            return planej.PcbRbNacAnoMenos11 * planej.StMedia;
        }

        public static float PstStNacAnoMenos9(PlanejVenda planej)      // EB
        {
            return planej.PcbRbNacAnoMenos10 * planej.StMedia;
        }

        public static float PstStNacAnoMenos8(PlanejVenda planej)      // EC
        {
            return planej.PcbRbNacAnoMenos9 * planej.StMedia;
        }

        public static float PstStNacAnoMenos7(PlanejVenda planej)      // ED
        {
            return planej.PcbRbNacAnoMenos8 * planej.StMedia;
        }

        public static float PstStNacAnoMenos6(PlanejVenda planej)      // EE
        {
            return planej.PcbRbNacAnoMenos7 * planej.StMedia;
        }

        public static float PstStNacAnoMenos5(PlanejVenda planej)      // EF
        {
            return planej.PcbRbNacAnoMenos6 * planej.StMedia;
        }

        public static float PstStNacAnoMenos4(PlanejVenda planej)      // EG
        {
            return planej.PcbRbNacAnoMenos5 * planej.StMedia;
        }

        public static float PstStNacAnoMenos3(PlanejVenda planej)      // EH
        {
            return planej.PcbRbNacAnoMenos4 * planej.StMedia;
        }

        public static float PstStNacAnoMenos2(PlanejVenda planej)      // EI
        {
            return planej.PcbRbNacAnoMenos3 * planej.StMedia;
        }

        public static float PstStNacAnoMenos1(PlanejVenda planej)      // EJ
        {
            return planej.PcbRbNacAnoMenos2 * planej.StMedia;
        }

        public static float PstStNacAno(PlanejVenda planej)      // EK
        {
            return planej.PcbRbNacAno * planej.StMedia;
        }

        public static float PfbFatBrAnoMenos12(PlanejVenda planej)      // EL
        {
            return planej.PcbRbNacAnoMenos12 + planej.PipiIpiNacAnoMenos12 + planej.PstStNacAnoMenos11;
        }

        public static float PfbFatBrAnoMenos11(PlanejVenda planej)      // EM
        {
            return planej.PcbRbNacAnoMenos11 + planej.PipiIpiNacAnoMenos11 + planej.PstStNacAnoMenos10;
        }

        public static float PfbFatBrAnoMenos10(PlanejVenda planej)      // EN
        {
            return planej.PcbRbNacAnoMenos10 + planej.PipiIpiNacAnoMenos10 + planej.PstStNacAnoMenos09;
        }

        public static float PfbFatBrAnoMenos9(PlanejVenda planej)      // EO
        {
            return planej.PcbRbNacAnoMenos9 + planej.PipiIpiNacAnoMenos9 + planej.PstStNacAnoMenos08;
        }

        public static float PfbFatBrAnoMenos8(PlanejVenda planej)      // EP
        {
            return planej.PcbRbNacAnoMenos8 + planej.PipiIpiNacAnoMenos8 + planej.PstStNacAnoMenos07;
        }

        public static float PfbFatBrAnoMenos7(PlanejVenda planej)      // EQ
        {
            return planej.PcbRbNacAnoMenos7 + planej.PipiIpiNacAnoMenos7 + planej.PstStNacAnoMenos06;
        }

        public static float PfbFatBrAnoMenos6(PlanejVenda planej)      // ER
        {
            return planej.PcbRbNacAnoMenos6 + planej.PipiIpiNacAnoMenos6 + planej.PstStNacAnoMenos05;
        }

        public static float PfbFatBrAnoMenos5(PlanejVenda planej)      // ES
        {
            return planej.PcbRbNacAnoMenos5 + planej.PipiIpiNacAnoMenos5 + planej.PstStNacAnoMenos04;
        }

        public static float PfbFatBrAnoMenos4(PlanejVenda planej)      // ET
        {
            return planej.PcbRbNacAnoMenos4 + planej.PipiIpiNacAnoMenos4 + planej.PstStNacAnoMenos03;
        }

        public static float PfbFatBrAnoMenos3(PlanejVenda planej)      // EU
        {
            return planej.PcbRbNacAnoMenos3 + planej.PipiIpiNacAnoMenos3 + planej.PstStNacAnoMenos02;
        }

        public static float PfbFatBrAnoMenos2(PlanejVenda planej)      // EV
        {
            return planej.PcbRbNacAnoMenos2 + planej.PipiIpiNacAnoMenos2 + planej.PstStNacAnoMenos01;
        }

        public static float PfbFatBrAnoMenos1(PlanejVenda planej)      // EW
        {
            return planej.PcbRbNacAno + planej.PipiIpiNacAno + planej.PstStNacAno00;
        }

        public static float PicmsIcmsNacAnoMenos12(PlanejVenda planej)      // EX
        {
            return planej.PcbRbNacAnoMenos12 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos11(PlanejVenda planej)      // EY
        {
            return planej.PcbRbNacAnoMenos11 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos10(PlanejVenda planej)      // EZ
        {
            return planej.PcbRbNacAnoMenos10 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos9(PlanejVenda planej)      // FA
        {
            return planej.PcbRbNacAnoMenos9 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos8(PlanejVenda planej)      // FB
        {
            return planej.PcbRbNacAnoMenos8 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos7(PlanejVenda planej)      // FC
        {
            return planej.PcbRbNacAnoMenos7 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos6(PlanejVenda planej)      // FD
        {
            return planej.PcbRbNacAnoMenos6 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos5(PlanejVenda planej)      // FE
        {
            return planej.PcbRbNacAnoMenos5 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos4(PlanejVenda planej)      // FF
        {
            return planej.PcbRbNacAnoMenos4 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos3(PlanejVenda planej)      // FG
        {
            return planej.PcbRbNacAnoMenos3 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos2(PlanejVenda planej)      // FH
        {
            return planej.PcbRbNacAnoMenos2 * planej.IcmsMedio;
        }

        public static float PicmsIcmsNacAnoMenos1(PlanejVenda planej)      // FI
        {
            return planej.PcbRbNacAno * planej.IcmsMedio;
        }

        public static float CrnFatBrutoNac(PlanejVenda planej)      // FJ
        {
            return planej.PfbFatBrAnoMenos12 + planej.PfbFatBrAnoMenos11 + planej.PfbFatBrAnoMenos10 +
                planej.PfbFatBrAnoMenos9 + planej.PfbFatBrAnoMenos8 + planej.PfbFatBrAnoMenos7 +
                planej.PfbFatBrAnoMenos6 + planej.PfbFatBrAnoMenos5 + planej.PfbFatBrAnoMenos4 +
                planej.PfbFatBrAnoMenos3 + planej.PfbFatBrAnoMenos2 + planej.PfbFatBrAno;
        }

        public static float CrnImpostos(PlanejVenda planej)      // FK
        {
            float a = planej.PicmsIcmsNacAnoMenos12 + planej.PicmsIcmsNacAnoMenos11 + planej.PicmsIcmsNacAnoMenos10 +
                planej.PicmsIcmsNacAnoMenos9 + planej.PicmsIcmsNacAnoMenos8 + planej.PicmsIcmsNacAnoMenos7 +
                planej.PicmsIcmsNacAnoMenos6 + planej.PicmsIcmsNacAnoMenos5 + planej.PicmsIcmsNacAnoMenos4 +
                planej.PicmsIcmsNacAnoMenos3 + planej.PicmsIcmsNacAnoMenos2 + planej.PicmsIcmsNacAno;
            float c = planej.PstStNacAnoMenos01 + planej.PstStNacAnoMenos02 + planej.PstStNacAnoMenos03 +
                planej.PstStNacAnoMenos04 + planej.PstStNacAnoMenos05 + planej.PstStNacAnoMenos06 +
                planej.PstStNacAnoMenos07 + planej.PstStNacAnoMenos08 + planej.PstStNacAnoMenos09 +
                planej.PstStNacAnoMenos10 + planej.PstStNacAnoMenos11 + planej.PstStNacAno00;
            float result = a + 0.0925f * planej.PcbRbNacTotal + c;

            return result;
        }

        public static float CrnRecLiquidaNacional(PlanejVenda planej)      // FL
        {
            return planej.CrnFatBrutoNac - planej.CrnImpostos;
        }

        public static float CrnComissaoNac(PlanejVenda planej)      // FM
        {
            return planej.ComissaoMediaNac * planej.PcbRbNacTotal;
        }

        public static float CrnFreteNac(PlanejVenda planej)      // FN
        {
            return planej.FreteNacPct * planej.CrnFatBrutoNac;
        }

        public static float CrnRecLiquidaVendaNac(PlanejVenda planej)      // FO
        {
            return planej.CrnRecLiquidaNacional - planej.CrnComissaoNac - planej.CrnFreteNac;
        }

        public static float CrnCustoDirMateriaisNac(PlanejVenda planej)      // FP
        {
            float result = planej.CustoDiretoMats * planej.PqQtNacTotal;

            return result;
        }

        public static float CrnCustoDirModNac(PlanejVenda planej)      // FQ
        {
            float result = planej.CustoDiretoMod * planej.PqQtNacTotal;

            return result;
        }

        public static float CrnFixoFabricaNac(PlanejVenda planej)      // FR
        {
            float result = planej.CustoFixoFabrica * planej.PqQtNacTotal;

            return result;
        }


        public static float CrnMCNac(PlanejVenda planej)      // FS
        {
            float result = planej.CrnRecLiquidaVendaNac - planej.CrnCustoDirMateriaisNac - planej.CrnCustoDirModNac - planej.CrnFreteNac;

            return result;
        }

        public static float CrnMCNacPct(PlanejVenda planej)      // FT
        {
            float result = Math.Abs(planej.CrnRecLiquidaNacional) > Global.Tolerance
                ? planej.CrnMCNac / planej.CrnRecLiquidaNacional
                : 0;

            return result;
        }

        public static float CrnCustoFixoAdmComNac(PlanejVenda planej)      // FU
        {
            float result = planej.CustoFixAdmCom * planej.PqQtNacTotal;

            return result;
        }

        public static float CrnResultadoBrutoNac(PlanejVenda planej)      // FV
        {
            float result = planej.CrnMCNac - planej.CrnCustoFixoAdmComNac;

            return result;
        }

        public static float CrnResultadoBrutoNacPct(PlanejVenda planej)      // FW
        {
            float result = Math.Abs(planej.CrnRecLiquidaNacional) > Global.Tolerance
                ? planej.CrnResultadoBrutoNac / planej.CrnRecLiquidaNacional
                : 0;

            return result;
        }

        public static float PqeQtExpAnoMenos12(PlanejVenda planej)       //GA
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos11 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos11(PlanejVenda planej)       //GB
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos10 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos10(PlanejVenda planej)       //GC
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos09 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos9(PlanejVenda planej)       //GD
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos08 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos8(PlanejVenda planej)       //GE
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos07 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos7(PlanejVenda planej)       //GF
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos06 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos6(PlanejVenda planej)       //GG
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos05 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos5(PlanejVenda planej)       //GH
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos04 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos4(PlanejVenda planej)       //GI
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos03 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos3(PlanejVenda planej)       //GJ
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos02 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos2(PlanejVenda planej)       //GK
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAnoMenos01 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpAnoMenos1(PlanejVenda planej)       //GL
        {
            float result = 0;
            float intermediate = 0;

            if (planej.Criterio != "x")
            {
                if (planej.Criterio == "m") intermediate = planej.QtExpMediaMensal * (1 + planej.PqeAumDim / 100f);
                else intermediate = planej.PqQtNacAno00 * (1 + planej.PqeAumDim / 100f);
            }

            result = (float)Math.Ceiling(intermediate); // (1 + $BU$2) onde BU2 Não tem valor definido!

            return result;
        }

        public static float PqeQtExpTotal(PlanejVenda planej)       // GM
        {
            float result = planej.PqeQtExpAnoMenos12 + planej.PqeQtExpAnoMenos11 + planej.PqeQtExpAnoMenos10 +
                planej.PqeQtExpAnoMenos9 + planej.PqeQtExpAnoMenos8 + planej.PqeQtExpAnoMenos7 +
                planej.PqeQtExpAnoMenos6 + planej.PqeQtExpAnoMenos5 + planej.PqeQtExpAnoMenos4 +
                planej.PqeQtExpAnoMenos3 + planej.PqeQtExpAnoMenos2 + planej.PqeQtExpAno;

            return result;
        }

        public static float PpleKgExpAnoMenos12(PlanejVenda planej)     // GN
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos12;

            return result;
        }

        public static float PpleKgExpAnoMenos11(PlanejVenda planej)     // GO
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos11;

            return result;
        }

        public static float PpleKgExpAnoMenos10(PlanejVenda planej)     // GP
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos10;

            return result;
        }

        public static float PpleKgExpAnoMenos9(PlanejVenda planej)     // GQ
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos9;

            return result;
        }

        public static float PpleKgExpAnoMenos8(PlanejVenda planej)     // GR
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos8;

            return result;
        }

        public static float PpleKgExpAnoMenos7(PlanejVenda planej)     // GS
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos7;

            return result;
        }

        public static float PpleKgExpAnoMenos6(PlanejVenda planej)     // GT
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos6;

            return result;
        }

        public static float PpleKgExpAnoMenos5(PlanejVenda planej)     // GU
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos5;

            return result;
        }

        public static float PpleKgExpAnoMenos4(PlanejVenda planej)     // GV
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos4;

            return result;
        }

        public static float PpleKgExpAnoMenos3(PlanejVenda planej)     // GW
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos3;

            return result;
        }

        public static float PpleKgExpAnoMenos2(PlanejVenda planej)     // GX
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAnoMenos2;

            return result;
        }

        public static float PpleKgExpAnoMenos1(PlanejVenda planej)     // GY
        {
            float result = planej.PesoUnitario * planej.PqeQtExpAno;

            return result;
        }

        public static float PpleKgExpTotal(PlanejVenda planej)      // GZ
        {
            float result = planej.PpleKgExpAnoMenos12 + planej.PpleKgExpAnoMenos11 + planej.PpleKgExpAnoMenos10 +
                planej.PpleKgExpAnoMenos9 + planej.PpleKgExpAnoMenos8 + planej.PpleKgExpAnoMenos7 +
                planej.PpleKgExpAnoMenos6 + planej.PpleKgExpAnoMenos5 + planej.PpleKgExpAnoMenos4 +
                planej.PpleKgExpAnoMenos3 + planej.PpleKgExpAnoMenos2 + planej.PpleKgExpAno;

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos12(PlanejVenda planej)     // HM
        {
            float result = planej.PqeQtExpAnoMenos12 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos12);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos11(PlanejVenda planej)     // HN
        {
            float result = planej.PqeQtExpAnoMenos11 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos11);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos10(PlanejVenda planej)     // HO
        {
            float result = planej.PqeQtExpAnoMenos10 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos10);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos9(PlanejVenda planej)     // HP
        {
            float result = planej.PqeQtExpAnoMenos9 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos9);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos8(PlanejVenda planej)     // HQ
        {
            float result = planej.PqeQtExpAnoMenos8 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos8);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos7(PlanejVenda planej)     // HR
        {
            float result = planej.PqeQtExpAnoMenos7 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos7);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos6(PlanejVenda planej)     // HS
        {
            float result = planej.PqeQtExpAnoMenos6 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos6);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos5(PlanejVenda planej)     // HT
        {
            float result = planej.PqeQtExpAnoMenos5 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos5);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos4(PlanejVenda planej)     // HU
        {
            float result = planej.PqeQtExpAnoMenos4 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos4);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos3(PlanejVenda planej)     // HV
        {
            float result = planej.PqeQtExpAnoMenos3 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos3);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos2(PlanejVenda planej)     // HW
        {
            float result = planej.PqeQtExpAnoMenos2 * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAnoMenos2);

            return result;
        }

        public static float PreUsdRcExpUsAnoMenos1(PlanejVenda planej)     // HX
        {
            float result = planej.PqeQtExpAno * planej.PvMedExAdotado * (1 + planej.PvppvaVPVexAno);

            return result;
        }

        public static float PreUsdRcExpUsRecExportUSD(PlanejVenda planej)     // HY
        {
            float result = planej.PreUsdRcExpUsAnoMenos12 + planej.PreUsdRcExpUsAnoMenos11 + planej.PreUsdRcExpUsAnoMenos10 +
                planej.PreUsdRcExpUsAnoMenos9 + planej.PreUsdRcExpUsAnoMenos8 + planej.PreUsdRcExpUsAnoMenos7 +
                planej.PreUsdRcExpUsAnoMenos6 + planej.PreUsdRcExpUsAnoMenos5 + planej.PreUsdRcExpUsAnoMenos4 +
                planej.PreUsdRcExpUsAnoMenos3 + planej.PreUsdRcExpUsAnoMenos2 + planej.PreUsdRcExpUsAno;

            return result;
        }

        public static string AnoMes(string data, DateTime referencia)
        {
            int diferenca = 0 - int.Parse(Function.Right(data, 2));
            string novaData = referencia.AddMonths(diferenca).ToString().Substring(0, 10);
            string anoMes = $"{Function.Right(novaData, 4)}-{novaData.Substring(3, 2)}";

            return anoMes;
        }
    }
}