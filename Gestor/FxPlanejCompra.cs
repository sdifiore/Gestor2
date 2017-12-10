﻿using Gestor.Models;
using System;
using System.Linq;

namespace Gestor
{
    public static class FxPlanejCompra
    {
        public static float FatorConsumo(PlanejCompra planej)       // R
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.QtdUnddConsumo;
            }

            return result;
        }

        public static float LoteCompra(PlanejCompra planej)       // S
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.QtdMltplCompra;
            }

            return result;
        }

        public static float EstoqueMinimo(PlanejCompra planej)      // T
        {
            var db = new ApplicationDbContext();
            string ptfe = XmlReader.Read("SemanaEstoquePtfe");
            string demais = XmlReader.Read("SemanaEstoqueDemais");
            int insumoId = planej.InsumoId;
            var insumo = db.Insumos.Single(i => i.InsumoId == insumoId);
            int categoriaId = insumo.CategoriaId;
            var categoria = db.Categorias.Single(ct => ct.CategoriaId == categoriaId);

            float a = categoria.Apelido == "50"
                ? db.SemanasEstoque.Single(S => S.Apelido == ptfe).Semanas
                : db.SemanasEstoque.Single(S => S.Apelido == demais).Semanas;

            float b = planej.SomaDe1 + planej.SomaDe2 + planej.SomaDe3 + planej.SomaDe4 + planej.SomaDe5 + planej.SomaDe6 +
                planej.SomaDe7 + planej.SomaDe8 + planej.SomaDe9 + planej.SomaDe10 + planej.SomaDe11 + planej.SomaDe12;

            int c = 0;
            if (Math.Abs(planej.SomaDe1) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe2) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe3) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe4) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe5) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe6) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe7) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe8) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe9) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe10) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe11) > Global.Tolerance) c++;
            if (Math.Abs(planej.SomaDe12) > Global.Tolerance) c++;

            float d = c > 3 ? 1 : 0;

            float result = a / 4 * b / 12 * planej.FatorConsumo * d;

            return result;
        }

        public static float PrecoUnitarioBruto (PlanejCompra planej)        // U
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.PrcBrtCompra;
            }

            return result;
        }

        public static float CustoUnitario(PlanejCompra planej)        // V
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.Custo;
            }

            return result;
        }

        public static float CreditoUnitIcms(PlanejCompra planej)        // W
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.CrdtIcms; // O valor CrdtICMS é ASSUMIDO, uma vez que a fórmula repetia o cálculo anterior indicando erro.
            }

            return result;
        }

        public static float CreditoUnitIpi(PlanejCompra planej)        // X
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.CrdtIpi;
            }

            return result;
        }

        public static float CreditoUnitPis(PlanejCompra planej)        // Y
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.CrdtPis;
            }

            return result;
        }

        public static float CreditoUnitCofins(PlanejCompra planej)        // Z
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.CrdtCofins;
            }

            return result;
        }

        public static float PagFornecImport(PlanejCompra planej)        // AA
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.PgtFornecImp;
            }

            return result;
        }

        public static float IiDespImport(PlanejCompra planej)        // AB
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.DspImportacao;
            }

            return result;
        }

        public static int MesRefPag1Fornec(PlanejCompra planej)       // AC
        {
            var db = new ApplicationDbContext();
            var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
            float intermediate = insumo != null
                ? insumo.Prazo1 / 30f
                : 0;
            int result = (int)Math.Round(intermediate, 0);

            return result;
        }

        public static int MesRefPag2Fornec(PlanejCompra planej)       // AD
        {
            var db = new ApplicationDbContext();
            var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
            float intermediate = insumo != null
                ? insumo.Prazo2 / 30f
                : 0;
            int result = (int)Math.Round(intermediate, 0);

            return result;
        }

        public static float PctPag1(PlanejCompra planej)       // AE
        {
            float result = 0;
            var db = new ApplicationDbContext();
            string comp = XmlReader.Read("InsumoNaoExistente");
            int id = db.Insumos.Single(i => i.Apelido == comp).InsumoId;

            if (planej.InsumoId != id)
            {
                var insumo = db.Insumos.SingleOrDefault(i => i.InsumoId == planej.InsumoId);
                if (insumo != null) result = insumo.PctPgto1;
            }

            return result;
        }
    }
}