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
            return (planej.QvQtNacAnoMenos12 + planej.QvQtNacAnoMenos11 + planej.QvQtNacAnoMenos10 + planej.QvQtNacAnoMenos09 +
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

            var d = planej.QvQtNacAnoMenos12 + planej.QvQtNacAnoMenos11 + planej.QvQtNacAnoMenos10;

            var result = Math.Abs(d) > Global.Tolerance
                            ? (a + b + c) / d
                            : float.MaxValue;

            return result;
        }

        public static float PvMed2o3m(PlanejVenda planej)       // AC
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

            var d = planej.QvQtNacAnoMenos09 + planej.QvQtNacAnoMenos08 + planej.QvQtNacAnoMenos07;

            var result = Math.Abs(d) > Global.Tolerance
                            ? (a + b + c) / d
                            : float.MaxValue;

            return result;
        }

        public static float PvMed3o3m(PlanejVenda planej)       // AC
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

            var d = planej.QvQtNacAnoMenos06 + planej.QvQtNacAnoMenos05 + planej.QvQtNacAnoMenos04;

            var result = Math.Abs(d) > Global.Tolerance
                ? (a + b + c) / d
                : float.MaxValue;

            return result;
        }

        public static float PvMed4o3m(PlanejVenda planej)       // AC
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

            var d = planej.QvQtNacAnoMenos03 + planej.QvQtNacAnoMenos02 + planej.QvQtNacAno00;

            var result = Math.Abs(d) > Global.Tolerance
                ? (a + b + c) / d
                : float.MaxValue;

            return result;
        }

        public static float PvNacAdotado(PlanejVenda planej)
        {

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