using System;
using Gestor.Models;
using System.Linq;

namespace Gestor
{
    public static class FxPlanejMod
    {
        public static float AnoMenos11(PlanejMod planej)        // Q
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe1 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos10(PlanejMod planej)        // R
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe2 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos9(PlanejMod planej)        // S
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe3 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos8(PlanejMod planej)        // T
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe4 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos7(PlanejMod planej)        // U
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe5 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos6(PlanejMod planej)        // V
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe6 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos5(PlanejMod planej)        // W
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe7 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos4(PlanejMod planej)        // X
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe8 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos3(PlanejMod planej)        // Y
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe9 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos2(PlanejMod planej)        // Z
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe10 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float AnoMenos1(PlanejMod planej)        // AA
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe11 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }

        public static float Ano(PlanejMod planej)        // AB
        {
            var db = new ApplicationDbContext();
            var ocupacao = db.Operacoes.SingleOrDefault(o => o.OperacaoId == planej.OperacaoId);
            float result = ocupacao != null
                ? planej.SomaDe12 * ocupacao.TaxaOcupacao
                : 0;

            return result;
        }
    }
}