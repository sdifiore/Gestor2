using System;
using Gestor.Models;
using System.Linq;

namespace Gestor
{
    public static class FxEstrutura
    {
        public static string DescCompProc(Estrutura register)   // G
        {
            var db = new ApplicationDbContext();
            string descCompProc = "";

            var insumo = db.Insumos.SingleOrDefault(i => i.Apelido == register.Item);

            if (insumo != null) descCompProc = insumo.Descricao;
            else
            {
                var produto = db.Produtos.SingleOrDefault(i => i.Apelido == register.Item);

                if (produto != null) descCompProc = produto.Descricao;
                else
                    if (register.Sequencia.Tipo.Substring(0, 1) == XmlReader.Read("SequenciaE1").Substring(0, 1))
                        descCompProc = $"Oper. de {db.Operacoes.Single(o => o.CodigoOperacao == register.Item).Descricao}";
            }

            return descCompProc;
        }

        public static string TipoItemCusto(Estrutura register)      // Q
        {
            string tipoItemCusto = "";

            if (register.Sequencia.Descricao != "")
            {
                var db = new ApplicationDbContext();
                string tipoNaoInformado = XmlReader.Read("TipoNaoInformado");
                var insumo = db.Insumos.SingleOrDefault(i => i.Apelido == register.Item);

                if (insumo == null)
                {
                    var produto = db.Produtos.SingleOrDefault(p => p.Apelido == register.Item);

                    if (produto == null)
                    {
                        var operacao = db.Operacoes.SingleOrDefault(o => o.CodigoOperacao == register.Item);

                        if (operacao == null)
                        {
                            DbLogger.Log(Reason.Error, $"Código {register.Item} não encontrado em Operações");
                            tipoItemCusto = Global.Erro;
                        }

                        else tipoItemCusto = $"c-MOD Setor {operacao.SetorProducao}";
                    }

                    else tipoItemCusto = db.Tipos.Single(t => t.TipoId == produto.TipoId).Descricao;
                }

                else tipoItemCusto = db.Tipos.First(i => i.TipoId == insumo.TipoId).Descricao;
            }

            return tipoItemCusto;
        }

        public static int UnidadeCompraId(Estrutura register)      // H
        {
            var db = new ApplicationDbContext();
            string unidadeNaoInformada = XmlReader.Read("UnidadeNaoInformada");
            string sequenciaE1 = XmlReader.Read("SequenciaE1").Substring(0, 1);
            string unidadeHora = XmlReader.Read("UnidadeUnidade");
            int result = db.Unidades.Single(u => u.Descricao == unidadeNaoInformada).UnidadeId;

            if (register.Sequencia.Descricao != "")
            {
                if (register.TpItmCst == XmlReader.Read("Insumos")) result = register.UnidadeId;

                else
                {
                    if (register.TpItmCst == XmlReader.Read("Manufaturado")) result = register.UnidadeId;

                    else
                    {
                        if (register.Sequencia.Descricao.Substring(0, 1) == sequenciaE1)
                            result = db.Unidades.Single(u => u.Descricao == unidadeHora).UnidadeId;
                        else result = db.Unidades.Single(u => u.Descricao == unidadeHora).UnidadeId;
                    }
                }
            }

            return result;
        }

        public static float CustoUnitCompra(Estrutura estrutura)        // I
        {
            var db = new ApplicationDbContext();
            float result = 0;

            if (estrutura.Item != "" && estrutura.Item != XmlReader.Read("ItemNaoExiste") && estrutura.TpItmCst != Global.Erro)
            {
                string comp = XmlReader.Read("Insumos");
                string tpItmCstComp = estrutura.TpItmCst + Global.Space20;

                if (tpItmCstComp.Substring(0, comp.Length) == comp)
                    result = db.Insumos.Single(i => i.Apelido == estrutura.Item).CustoUndCnsm;
                else
                {
                    comp = XmlReader.Read("Manufaturado");

                    if (tpItmCstComp.Substring(0, comp.Length) == comp)
                        result = db.Produtos.Single(p => p.Apelido == estrutura.Item).CustODirTotal;
                    else
                        result = db.Operacoes.Single(o => o.CodigoOperacao == estrutura.Item).Custo;
                }
            }


            return result;
        }

        public static float QtEftvUntrCmpnt(Estrutura estrutura)
        {
            var db = new ApplicationDbContext();

            float a = estrutura.Onera
                ? 1
                : -1;

            float kd = estrutura.AlrtSbPrdt == XmlReader.Read("Subproduto")
                ? 1
                : 1 / (1 - estrutura.Perda);

            float c = estrutura.QtdCusto > Global.Tolerance
                ? estrutura.Lote / estrutura.QtdCusto * kd
                : 0;

            float b = estrutura.Sequencia.Tipo == XmlReader.Read("SequenciaE1").Substring(0, 1)
                ? db.Operacoes.Single(o => o.CodigoOperacao == estrutura.Item).Custo
                : 0;

            return a * b * c;
        }

        public static float CstCmprUndPrd(Estrutura estrutura)
        {
            float r = estrutura.AlrtSbPrdt == XmlReader.Read("Subproduto")
                ? 1 - estrutura.Perda
                : 1;

            return estrutura.QtEftvUntrCmpnt * estrutura.CustoUnitCompra * r;
        }

        public static float PartCusto(Estrutura estrutura)      // N
        {
            var db = new ApplicationDbContext();
            var stru = db.Estruturas.Where(e => e.Produto.Apelido == estrutura.Item);
            float result = 0;

            if (stru.Any())
            {
                float soma = stru.Sum(e => e.CustoUnitCompra);
                result = soma < Global.Tolerance
                    ? 0
                    : estrutura.CustoUnitCompra / soma;
            }

            return result;
        }

        public static string AlrtSbPrdt(Estrutura estrutura)        // R
        {
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Apelido == estrutura.Item);

            string result = produto != null
                ? db.Categorias.Single(c => c.CategoriaId == produto.CategoriaId).Descricao
                : "";

            return result;
        }

        public static float TempMaq(Estrutura estrutura)        // S
        {
            var db = new ApplicationDbContext();
            string tpItmCst = $"{estrutura.TpItmCst}{Global.Space20}";
            float result = tpItmCst.Substring(0, 5) == "c-MOD"
                ? db.Operacoes.Single(o => o.CodigoOperacao == estrutura.Item).TaxaOcupacao
                : 0;

            return result;
        }

        public static float PsLiqdFnl(Estrutura estrutura)      // U
        {
            float result = estrutura.QtdCusto > Global.Tolerance && estrutura.Sequencia.Descricao == "A" &&
                           estrutura.UnidadeCompra.Apelido == "Kg"
                ? estrutura.Lote / estrutura.QtdCusto
                : 0;

            return result;
        }

        public static float PesoLiqPrec(Estrutura estrutura)    // V
        {
            var db = new ApplicationDbContext();
            float result = estrutura.Sequencia.Descricao == XmlReader.Read("SequenciaA") && estrutura.UnidadeCompra.Apelido == "Kg" &&
                           estrutura.TpItmCst == XmlReader.Read("Manufaturado")
                ? db.Estruturas.Where(e => e.Produto.Apelido == estrutura.Item).Sum(e => e.PsLiqdFnl) * estrutura.Lote /
                  estrutura.QtdCusto
                : 0;

            return result;
        }

        public static float HrsModFnl(Estrutura estrutura)      // W
        {
            float result = estrutura.QtdCusto > Global.Tolerance &&
                           estrutura.Sequencia.Descricao == XmlReader.Read("SequenciaE1").Substring(0, 1) &&
                           estrutura.UnidadeCompra.Apelido == "Kg"
                ? estrutura.QtEftvUntrCmpnt
                : 0;

            return result;
        }

        public static float HrsModPrec1(Estrutura estrutura)        // X
        {
            var db = new ApplicationDbContext();
            float result = estrutura.TpItmCst == XmlReader.Read("Manufaturado") && estrutura.Onera
                ? db.Produtos.Single(p => p.Apelido == estrutura.Item).HorasModUltmEtapa
                : 0;

            return result;
        }

        public static float HrsModPrec2(Estrutura estrutura)        // Y
        {
            var db = new ApplicationDbContext();
            float result = estrutura.TpItmCst == XmlReader.Read("Manufaturado") && estrutura.Onera
                ? db.Produtos.Single(p => p.Apelido == estrutura.Item).HorasModEtapa1
                : 0;

            return result;
        }

        public static string IdProd(Estrutura estrutura)        // Z
        {
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Apelido == estrutura.Item);

            if (produto == null)
            {
                DbLogger.Log(Reason.Error,$"Erro: Produto {estrutura.Item} não encontrado");
                return "Erro";
            }

            var unidade = db.Unidades.Single(u => u.UnidadeId == estrutura.UnidadeId);
            return $"{produto.Descricao}-{produto.Apelido}-{unidade.Apelido}";
        }

        public static string IdCmpnt(Estrutura estrutura)       // AA
        {
            var db = new ApplicationDbContext();
            string unidade = db.Unidades.Single(u => u.UnidadeId == estrutura.UnidadeId).Apelido;

            return $"{estrutura.Item}-{estrutura.DescCompProc}-{unidade}";
        }

        public static float PdrHoraria(Estrutura estrutura)     // AB
        {
            float result = 0;

            if (estrutura.Sequencia.Descricao == XmlReader.Read("SequenciaE1").Substring(0, 1))
            {
                if (estrutura.Lote > Global.Tolerance)
                {
                    result = estrutura.QtdCusto / estrutura.Lote / (1 - estrutura.Perda);
                }
            }

            return result;
        }

        public static string ProdComp(Estrutura estrutura)      // AC
        {
            return $"{estrutura.Produto.Apelido}-{estrutura.Item}";
        }

        public static float CstIndividual(Estrutura estrutura)      // AD
        {
            var db = new ApplicationDbContext();

            return db.Produtos.Single(p => p.Apelido == estrutura.Produto.Apelido).QtdUnid;
        }

        public static float CstMtrlDrt(Estrutura estrutura)     // AE
        {
            float result = 0;

            if (estrutura.Sequencia.Tipo == XmlReader.Read("SequenciaB") ||
                estrutura.Sequencia.Tipo == XmlReader.Read("SequenciaC") ||
                estrutura.Sequencia.Tipo == XmlReader.Read("SequenciaD") ||
                estrutura.Sequencia.Tipo == XmlReader.Read("SequenciaA") &&
                estrutura.TpItmCst == XmlReader.Read("Insumos"))
            {
                result = estrutura.CstCmprUndPrd;
            }

            return result;
        }

        public static float CstMtrlPrcd1(Estrutura estrutura)       // AF
        {
            var db = new ApplicationDbContext();
            float result = 0;

            if (estrutura.Sequencia.Tipo == XmlReader.Read("SequenciaA") && estrutura.TpItmCst == XmlReader.Read("Manufaturado"))
                result = db.Produtos.Single(p => p.Apelido == estrutura.Item).CstMatUltmEtapa * estrutura.QtEftvUntrCmpnt;

            return result;
        }

        public static float CstMtrlPrcd2(Estrutura estrutura)       // AG
        {
            var db = new ApplicationDbContext();
            float result = 0;

            if (estrutura.Sequencia.Tipo == XmlReader.Read("SequenciaA") && estrutura.TpItmCst == XmlReader.Read("Manufaturado"))
                result = db.Produtos.Single(p => p.Apelido == estrutura.Item).CstMatEtapa1 * estrutura.QtEftvUntrCmpnt;

            return result;
        }

        public static float CstMtrlPrcd3(Estrutura estrutura)       // AH
        {
            var db = new ApplicationDbContext();
            float result = 0;

            if (estrutura.Sequencia.Tipo == XmlReader.Read("SequenciaA") && estrutura.TpItmCst == XmlReader.Read("Manufaturado"))
                result = db.Produtos.Single(p => p.Apelido == estrutura.Item).CstMatEtapa2 * estrutura.QtEftvUntrCmpnt;

            return result;
        }
    }
}