using Gestor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor
{
    public static class FxPrecoExportacao
    {
        public static float De2A5(PrecoExportacao preco)        // F
        {
            var db = new ApplicationDbContext();
            var indices = db.Indices;
            float x = 0;
            float y = preco.DespExpPadrao
                ? db.DespesasExportacao.Single(d => d.Tipo == "1").Valor
                : preco.PctDespExportEspec;
            float z = preco.QtUnid == 0 ? 1 : preco.QtUnid;

            if (preco.CondicaoPreco.Apelido != "EXW")
            {
                if (preco.CondicaoPreco.Apelido != "FOB") x = preco.PctEspecFrete;
                else
                {
                    string temp = XmlReader.Read("FreteNacionalPadrao");
                    x = indices.Single(i => i.Descricao == temp).Exportacao;
                }
            }

            float result = (preco.CustoDireto + preco.RateioCustoFixo * preco.PctRateio) * 0.674f /
                (0.674f * (1 - preco.Com -
                x -
                preco.IEfetiva - y) -
                (preco.LlMin + 3 * db.DespesasExportacao.Single(d => d.Tipo == "LL").Valor)) /
                z / db.Parametros.First().Dolar;

            return result;
        }

        public static float De5A10(PrecoExportacao preco)       // G
        {
            var db = new ApplicationDbContext();
            var indices = db.Indices;
            float x = 0;
            float y = preco.DespExpPadrao
                ? db.DespesasExportacao.Single(d => d.Tipo == "2").Valor
                : preco.PctDespExportEspec;
            float z = preco.QtUnid == 0 ? 1 : preco.QtUnid;

            if (preco.CondicaoPreco.Apelido != "EXW")
            {
                if (preco.CondicaoPreco.Apelido != "FOB") x = preco.PctEspecFrete;
                else
                {
                    string temp = XmlReader.Read("FreteNacionalPadrao");
                    x = indices.Single(i => i.Descricao == temp).Exportacao;
                }
            }

            float result = (preco.CustoDireto + preco.RateioCustoFixo * preco.PctRateio) * 0.674f /
                (0.674f * (1 - preco.Com -
                x -
                preco.IEfetiva - y) -
                (preco.LlMin + 2 * db.DespesasExportacao.Single(d => d.Tipo == "LL").Valor)) /
                z / db.Parametros.First().Dolar;

            return result;
        }

        public static float De10A20(PrecoExportacao preco)      // H
        {
            var db = new ApplicationDbContext();
            var indices = db.Indices;
            float x = 0;
            float y = preco.DespExpPadrao
                ? db.DespesasExportacao.Single(d => d.Tipo == "3").Valor
                : preco.PctDespExportEspec;
            float z = preco.QtUnid == 0 ? 1 : preco.QtUnid;

            if (preco.CondicaoPreco.Apelido != "EXW")
            {
                if (preco.CondicaoPreco.Apelido != "FOB") x = preco.PctEspecFrete;
                else
                {
                    string temp = XmlReader.Read("FreteNacionalPadrao");
                    x = indices.Single(i => i.Descricao == temp).Exportacao;
                }
            }

            float result = (preco.CustoDireto + preco.RateioCustoFixo * preco.PctRateio) * 0.674f /
                (0.674f * (1 - preco.Com -
                x -
                preco.IEfetiva - y) -
                (preco.LlMin + db.DespesasExportacao.Single(d => d.Tipo == "LL").Valor)) /
                z / db.Parametros.First().Dolar;

            return result;
        }

        public static float Acima20(PrecoExportacao preco)      // I
        {
            var db = new ApplicationDbContext();
            var indices = db.Indices;
            float x = 0;
            float y = preco.DespExpPadrao
                ? db.DespesasExportacao.Single(d => d.Tipo == "4").Valor
                : preco.PctDespExportEspec;
            float z = preco.QtUnid == 0 ? 1 : preco.QtUnid;

            if (preco.CondicaoPreco.Apelido != "EXW")
            {
                if (preco.CondicaoPreco.Apelido != "FOB") x = preco.PctEspecFrete;
                else
                {
                    string temp = XmlReader.Read("FreteNacionalPadrao");
                    x = indices.Single(i => i.Descricao == temp).Exportacao;
                }
            }

            float result = (preco.CustoDireto + preco.RateioCustoFixo * preco.PctRateio) * 0.674f /
                (0.674f * (1 - preco.Com -
                x -
                preco.IEfetiva - y) -
                preco.LlMin)  /
                z / db.Parametros.First().Dolar;

            return result;
        }

        public static float IEfetiva(PrecoExportacao preco)     // O
        {
            var db = new ApplicationDbContext();
            var indices = db.Indices;
            string temp = XmlReader.Read("Taxa30DDL");
            float taxa = indices.Single(i => i.Descricao == temp).Proprio;
            float result = (float)Math.Pow(Math.Pow(1 + taxa, 1 / 30), preco.CondPag - 1);

            return result;
        }

        public static float PvFobMax(PrecoExportacao preco)     // S
        {
            float result = preco.De2A5 < Global.Tolerance
                ? (float)Math.Round(preco.De2A5 * preco.QtUnid, 2)
                : 0;

            return result;
        }

        public static float PvFobMin(PrecoExportacao preco)     // V
        {
            float result = preco.Acima20 < Global.Tolerance
                ? (float)Math.Round(preco.Acima20 * preco.QtUnid, 2)
                : 0;

            return result;
        }

        public static float ValorCifPtfe(PrecoExportacao preco)     // W
        {

            // Resolver tab Produtos primeiramente

            return 0;
        }
    }
}