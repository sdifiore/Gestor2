using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;
using Gestor.Models;

namespace Gestor
{
    public static class Populate
    {
        public static List<CustoInsumo> CustoInsumo()
        {
            var result = new List<CustoInsumo>();
            var db = new ApplicationDbContext();
            var parm = db.Parametros.ToList().Last();
            var model = db.Insumos.Include(i => i.Finalidade).ToList();
            int index = 1;

            foreach (var register in model)
            {
                var data = new CustoInsumo
                {
                    PrcBrtCmpr = Math.Abs(register.PrecoUsd) > Global.Tolerance
                        ? parm.Dolar * register.PrecoUsd * (1 + register.Ipi)
                        : register.PrecoRs * (1 + register.Ipi)
                };

                data.CustoInsumoId = index++;
                data.CrdtIcms = data.PrcBrtCmpr / (1 + register.Ipi) * register.Icms;
                data.CrdtIpi = data.PrcBrtCmpr / (1 + register.Ipi) * register.Ipi;
                data.CrdtPis = data.PrcBrtCmpr / (1 + register.Ipi) * register.Pis;
                data.CrdtCofins = data.PrcBrtCmpr / (1 + register.Ipi) * register.Cofins;
                data.SumCrdtImpostos = data.PrcBrtCmpr + data.CrdtIcms + data.CrdtIpi + data.CrdtPis + data.CrdtCofins;
                data.DespImport = data.PrcBrtCmpr / (1 + register.Ipi) * register.DespImport;
                data.CustoExtra = data.PrcBrtCmpr / (1 + register.Ipi) * register.DespExtra;
                data.Custo = data.PrcBrtCmpr - data.CrdtIcms - data.CrdtPis - data.CrdtCofins + data.CustoExtra;
                data.Custo = register.Finalidade.Descricao == XmlReader.Read("Revenda")
                    ? data.Custo
                    : data.Custo - data.CrdtIpi;
                data.CstUndConsumo = data.Custo * register.QtdUnddConsumo;
                data.PgmtoFornecImport = Math.Abs(data.DespImport) > Global.Tolerance
                    ? data.PrcBrtCmpr - data.SumCrdtImpostos - data.DespImport
                    : 0;
                data.UsoStrut = db.Estruturas.Count(e => e.Item == register.Apelido);
                data.Produto = db.Produtos.Single(p => p.Apelido == register.Apelido);

                result.Add(data);
            }

            return result;
        }

        public static List<DetalheProduto> DetalheProduto()
        {
            var result = new List<DetalheProduto>();
            var db = new ApplicationDbContext();
            var model = db.Produtos;
            int index = 1;

            foreach (var register in model)
            {
                var data = new DetalheProduto
                {
                    DetalheProdutoId = index++
                };
            }

            return result;
        }

        public static void Estrutura()
        {
            var db = new ApplicationDbContext();
            var model = db.Estruturas
                .Include(e => e.Produto)
                .ToList();
            string compAlias = Global.CompAlias;
            Insumo();

            foreach (var register in model)
            {
                register.Header = false;

                if (register.Produto.Apelido == compAlias)
                {
                    register.Header = true;
                    register.Produto.Apelido = register.Produto.Apelido;
                }

                register.DescCompProc = FxEstrutura.DescCompProc(register); // G
                register.TpItmCst = FxEstrutura.TipoItemCusto(register); // Q
                register.UnidadeCompraId = FxEstrutura.UnidadeCompraId(register, register.TpItmCst); // H
                Insumo();

                /* *************************************
                     * 
                     *  Requer a aba produto
                     *  
                     *  *********************************** */

                register.CustoUnitCompra = FxEstrutura.CustoUnitCompra(register, register.TpItmCst); // I

                db.SaveChanges();
            }
        }

            public static void Insumo()
        {
            var db = new ApplicationDbContext();
            var model = db.Insumos
                .Include(i => i.Finalidade)
                .ToList();
            var estrutura = db.Estruturas.ToList();
            float dolar = db.Parametros.OrderByDescending(p => p.Data).First().Dolar;

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
                    ? register.PrcBrtCompra - register.SumCrdImpostos - register.DespImport
                    : 0;
                register.UsoStru = estrutura.Count(e => e.Item == register.Apelido);
            }

            db.SaveChanges();
        }
    }
}