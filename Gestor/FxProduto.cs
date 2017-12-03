using Gestor.Models;
using System;
using System.Linq;

namespace Gestor
{
    public static class FxProduto
    {
        public static float PesoLiquidoCalc(Produto produto)        // R
        {
            var db = new ApplicationDbContext();
            var comp = XmlReader.Read("SequenciaA");
            var estrutura = db.Estruturas;
            var operando = estrutura.Where(e => e.ProdutoId == produto.Id && e.Sequencia.Tipo == comp);
            float final = operando.Any()
                ? operando.Sum(e => e.PsLiqdFnl) + operando.Sum(e => e.PsLiqdPrcdt)
                : 0;

            return final;
        }

        public static int ItemStru(Produto produto)     // S
        {
            var db = new ApplicationDbContext();
            var result = db.Estruturas.Count(e => e.ProdutoId == produto.Id);

            return result;
        }

        public static float CustoDirTotal(Produto produto)      // T
        {
            var db = new ApplicationDbContext();
            float result;
            IQueryable<Estrutura> estrutura;

            if (produto.Categoria.Descricao != XmlReader.Read("MercadoriaRevenda"))
            {
                estrutura = db.Estruturas.Where(e => e.ProdutoId == produto.Id);
                result = estrutura.Any() ? estrutura.Sum(e => e.CstCmprUndPrd) : 0;
            }
                
            else
                result = db.Insumos.Where(i => i.Apelido == produto.Apelido).Sum(i => i.CustoUndCnsm);

            return result;
        }

        public static float CstMatUltmEtapa(Produto produto)        // U
        {
            var db = new ApplicationDbContext();
            var operando = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido);
            var result = operando.Any()
                ? operando.Sum(e => e.CstMtrlDrt)
                : 0;

            return result;
        }

        public static float CstMatEtapa1(Produto produto)        // V
        {
            var db = new ApplicationDbContext();
            var operando = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido);
            var result = operando.Any()
                ? operando.Sum(e => e.CstMtrlPrcd1)
                : 0;

            return result;
        }

        public static float CstMatEtapa2(Produto produto)        // W
        {
            var db = new ApplicationDbContext(); var operando = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido);
            var result = operando.Any()
                ? operando.Sum(e => e.CstMtrlPrcd2)
                : 0;

            return result;
        }

        public static float CstMatEtapa3(Produto produto)        // X
        {
            var db = new ApplicationDbContext(); var operando = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido);
            var result = operando.Any()
                ? operando.Sum(e => e.CstMtrlPrcd3)
                : 0;

            return result;
        }

        public static float CstTotMaterial(Produto produto)     // Y
        {
            return produto.CstMatUltmEtapa + produto.CstMatEtapa3;
        }

        public static float CustoDirMod(Produto produto)        // Z
        {
            float result = produto.ClasseCusto.Descricao == XmlReader.Read("MercadoriaRevenda")
                ? produto.CustODirTotal - produto.CstTotMaterial
                : 0;

            return result;
        }

        public static float HorasModUltmEtapa(Produto produto)      // AA
        {
            var db = new ApplicationDbContext();
            var comp1 = XmlReader.Read("SequenciaE1");
            var comp2 = XmlReader.Read("SequenciaE2");
            var estrutura = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido && e.Sequencia.Tipo == comp1);
            float a = estrutura.Any() ? estrutura.Sum(e => e.HrsModFnl) : 0;
            estrutura = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido && e.Sequencia.Tipo == comp2);
            float b = estrutura.Any() ? estrutura.Sum(e => e.HrsModFnl) : 0;
            float result = a + b;

            return result;
        }

        public static float HorasModEtapa1(Produto produto)     // AB
        {
            var db = new ApplicationDbContext();
            var operando = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido);
            float result = operando.Any()
                ? operando.Sum(e => e.HrsModPrec1)
                : 0;

            return result;
        }

        public static float HorasModEtapa2(Produto produto)     // AC
        {
            var db = new ApplicationDbContext();
            var operando = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido);
            float result = operando.Any()
                ? operando.Sum(e => e.HrsModPrec2)
                : 0;

            return result;
        }

        public static float HorasModTotal(Produto produto)      // AD
        {
            return produto.HorasModUltmEtapa + produto.HorasModEtapa1 + produto.HorasModEtapa2;
        }

        public static float CapProdHora(Produto produto)        // AE
        {
            var db = new ApplicationDbContext();
            var comp = XmlReader.Read("SequenciaE1");
            var operando = db.Estruturas.Where(e => e.Produto.Apelido == produto.Apelido && e.Sequencia.Tipo == comp);
            var result = operando.Any()
                ? operando.Sum(e => e.PdrHoraria)
                : 0;

            return result;
        }

        public static int LoteMinimo(Produto produto)     // AF
        {
            var db = new ApplicationDbContext();
            string grupoDeRateio = db.GruposRateio.Single(gr => gr.GrupoRateioId == produto.GrupoRateioId).Descricao;
            var rateio = db.Rateios.SingleOrDefault(r => r.Grupo.ToLower() == grupoDeRateio.ToLower());
            int result = 0;

            if (rateio != null)
            {
                float temp = (float)Math.Ceiling(rateio.Horas * produto.CapProdHora);
                if (Math.Abs(produto.QtUnPorUnArmz) < Global.Tolerance) temp = 0;
                result = temp > produto.QtUnPorUnArmz ? (int)temp : produto.QtUnPorUnArmz;
            }

            return result;
        }

        public static int UsoStru(Produto produto)      // AG
        {
            var db = new ApplicationDbContext();

            return db.Estruturas.Count(e => e.Item == produto.Apelido);
        }

        public static int CustoDir(Produto produto)     // AH
        {
            int result = produto.PesoLiquidoCalc > Global.Tolerance
                ? (int)Math.Round(produto.CustODirTotal / produto.PesoLiquidoCalc)
                : 0;

            return result;
        }

        public static int RelModCstDir(Produto produto)     // AI
        {
            int result = produto.CustODirTotal > Global.Tolerance
                ? (int)Math.Round(produto.CustoDirMod / produto.CustODirTotal)
                : 0;

            return result;
        }

        public static int PctMatEtapaFinal(Produto produto)     // AI
        {
            int result = produto.CstTotMaterial > Global.Tolerance
                ? (int)Math.Round(produto.CstMatUltmEtapa / produto.CstTotMaterial)
                : 0;

            return result;
        }

        public static int PctMatEtapa1(Produto produto)     // AK
        {
            int result = produto.CstTotMaterial > Global.Tolerance
                ? (int)Math.Round(produto.CstMatEtapa1 / produto.CstTotMaterial)
                : 0;

            return result;
        }

        public static int PctMatEtapa2(Produto produto)     // AL
        {
            int result = produto.CstTotMaterial > Global.Tolerance
                ? (int)Math.Round(produto.CstMatEtapa2 / produto.CstTotMaterial)
                : 0;

            return result;
        }

        public static int PctMatEtapa3(Produto produto)     // AM
        {
            int result = produto.CstTotMaterial > Global.Tolerance
                ? (int)Math.Round(produto.CstMatEtapa3/ produto.CstTotMaterial)
                : 0;

            return result;
        }

        public static float CustoFixoTotal(Produto produto)     // Planilha 2, S
        {
            return 0;
        }

        public static float MoiFabricacao(Produto produto)     // Planilha 2, T
        {
            return 0;
        }
    }
}