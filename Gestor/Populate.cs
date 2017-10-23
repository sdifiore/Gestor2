using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                data.Custo = register.Finalidade.Descricao == "Revenda"
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

        public static List<DetalheEstrutura> DetalheEstrutura()
        {
            var result = new List<DetalheEstrutura>();
            var db = new ApplicationDbContext();
            var model = db.Estruturas
                .Include(m => m.Produto)
                .Include(m => m.Produto.Unidade);

            string frase;
            string compAlias = "§§§§";
            int index = 1;
            int QtdUndd;
            float tolerance = 0.0001f;
            float PartCusto;
            float QtEftvUntrCmpnt;
            float CstCmprUndPrd;
            float TempMaq;
            float PsLiqdFnl;
            float HrsModFnl;
            float HrsModPrec1;
            float HrsModPrec2;
            float PdrHoraria;
            float ProdComp;
            float CstMtrlDrt;
            float CstMtrlPrcd1;
            float CstMtrlPrcd2;
            float CstMtrlPrcd3;

            foreach (var register in model)
            {
                var data = new DetalheEstrutura
                {
                    DetalheEstruturaId = index++
                };

                data.Header = false;
                if (compAlias != register.Apelido)
                {
                    data.Header = true;
                    data.IdProd = $"{register.Produto.Apelido}-{register.Produto.Descricao}-{register.Produto.Unidade.Descricao}";
                    data.AlrtSbPrdt = register.Produto.ClasseCusto.Descricao;
                    compAlias = register.Apelido;
                    PartCusto = 0;
                    QtEftvUntrCmpnt = 0;
                    CstCmprUndPrd = 0;
                    TempMaq = 0;
                    QtdUndd = 0;
                    PsLiqdFnl = 0;
                    HrsModFnl = 0;
                    HrsModPrec1 = 0;
                    HrsModPrec2 = 0;
                    PdrHoraria = 0;
                    ProdComp = 0;
                    CstMtrlDrt = 0;
                    CstMtrlPrcd1 = 0;
                    CstMtrlPrcd2 = 0;
                    CstMtrlPrcd3 = 0;
                }


                // Estrutura R: Alerta de Sub-Produto: =SE(A2=PROC(A2;Produtos!A:A);PROC(A2;Produtos!A:A;Produtos!E:E);)

                data.AlrtSbPrdt = register.Produto.ClasseCusto.Descricao;

                // Estrutura O: Qt Efet Unit do comp: =SE(J2="desonera";-1;1)*SE(EXT.TEXTO(E2;1;1)="E";PROC(F2;Processo!$A:$A;Processo!$D:$D);1)*SE(D2<>0; K2/D2*SE(R2="05.Subproduto";1;1/(1-L2));)

                frase = XmlReader.Find("Subproduto");
                float onera = register.Onera ? 1 : -1;
                var operacao = db.Operacoes.Single(o => o.CodigoOperacao == register.Apelido);
                if (operacao == null)

                {
                    DbLogger.Log(Reason.Error, $"Operação {register.Apelido} não existe na tabela Operacoes");
                    throw new InvalidOperationException($"Operação {register.Apelido} não existe na tabela Operacoes");
                }

                float processo = register.Sequencia.Descricao.Substring(0, 1) == "E" ? operacao.TaxaOcupacao : 1;
                float x = data.AlrtSbPrdt == frase ? 1 : 1 / (1 - register.Perda);
                float y = Math.Abs(register.QtdCusto) < tolerance ? x : register.Lote / register.QtdCusto;
                data.QtEftvUntrCmpnt = onera * processo * y;

                // Estrutura Q: Tipo do item de Custo: =SE(F2="";"";SEERRO(SE(É.NÃO.DISP(PROCV(F2;Insumos!A:D;4;FALSO));PROCV(F2;Produtos!$A$1:$I$30027;4;0);PROCV(F2;Insumos!A:D;4;FALSO));"c-MOD Setor "&PROCV(F2;Processo!$A$1:$H$30006;2;0)))

                string tipo;
                var estrutura = db.Estruturas.SingleOrDefault(i => i.Apelido == register.Apelido);

                if (estrutura == null)

                {
                    DbLogger.Log(Reason.Error, $"Operação {register.Apelido} não existe na tabela Estruturas");
                    throw new InvalidOperationException($"Operação {register.Apelido} não existe na tabela Estruturas");
                }


                if (estrutura.Item == null)
                {
                    tipo = "";
                }

                else
                {
                    var produto = db.Produtos.SingleOrDefault(i => i.Apelido == register.Apelido);

                    if (produto == null)

                    {
                        DbLogger.Log(Reason.Error, $"Operação {register.Apelido} não existe na tabela Produtos");
                        throw new InvalidOperationException($"Operação {register.Apelido} não existe na tabela Produtos");
                    }

                    tipo = produto.Tipo.Descricao;
                    if (tipo == null)
                    {
                        tipo = $"c-MOD Setor {db.Operacoes.Single(o => o.CodigoOperacao == register.Apelido).SetorProducao}";
                    } 
                }

                data.TpItmCst = tipo;


                // Estrutura I: Custo Unit do compon: =SE(F3<>0;SE(Q3="b-Insumos / Mat. Prima";PROCV(F3;Insumos!A:AL;38;FALSO);SE(Q3="a-Manufaturado";PROC(F3;Produtos!A:A;Produtos!T:T);PROC(F3;Processo!A:A;Processo!G:G)));)

                frase = XmlReader.Find("Insumos");
                estrutura = db.Estruturas.SingleOrDefault(i => i.Apelido == register.Apelido);

                if (estrutura == null)

                {
                    DbLogger.Log(Reason.Error, $"Operação {register.Apelido} não existe na tabela Estruturas");
                    throw new InvalidOperationException($"Operação {register.Apelido} não existe na tabela Estruturas");
                }

                if (estrutura.Item == null)
                {
                    if (tipo == frase)
                    {
                        // continuar daqui
                    }
                }

                // Estrutura P: Cst comp por Un do prod R$/un: =O2*I2*SE(R2="05.Subproduto";(1-L2);1)
            }



            return result;
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
                string frase = XmlReader.Find("Revenda");
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