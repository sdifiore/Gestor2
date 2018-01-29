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
                {
                    if (register.Sequencia.Tipo.Substring(0, 1) == XmlReader.Read("SequenciaE1").Substring(0, 1))
                    {
                        var operando = db.Operacoes.SingleOrDefault(o => o.CodigoOperacao == register.Item);
                        if (operando != null)
                        {
                            descCompProc = $"Oper. de {operando.Descricao}";
                        }

                        else
                        {
                            DbLogger.Log(Reason.Error, $"DescComProc: Código {register.Item} não encontrado");
                            descCompProc = "Erro";
                        }
                    }
                }
            }

            return descCompProc;
        }

        public static string TipoItemCusto(Estrutura register)      // Q
        {
            string tipoItemCusto = "";
            string boh = register.Produto.Apelido;
            string mah = register.Item;

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

        public static float QtEftvUntrCmpnt(Estrutura estrutura)        // O
        
            {
            var db = new ApplicationDbContext();

            float a = estrutura.Onera
                ? 1
                : -1;

            float kd = estrutura.AlrtSbPrdt == XmlReader.Read("Subproduto")
                ? 1
                : 1 / (1 - estrutura.Perda);

            float c = Math.Abs(estrutura.QtdCusto) > Global.Tolerance
                ? estrutura.Lote / estrutura.QtdCusto * kd
                : 0;

            float b = 1;

            if (estrutura.Sequencia.Tipo.Substring(0, 1) == XmlReader.Read("SequenciaE1").Substring(0, 1))
            {
                var operacao = db.Operacoes.SingleOrDefault(o => o.CodigoOperacao == estrutura.Item);
                if (operacao != null) b = operacao.TaxaOcupacao;
            }

            float result = a * b * c;

            return result;
        }

        public static float CstCmprUndPrd(Estrutura estrutura)      // P
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
                result = Math.Abs(soma) < Global.Tolerance
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
                ? db.ClassesCusto.Single(c => c.ClasseCustoId == produto.ClasseCustoId).Descricao
                : "";

            return result;
        }

        public static float TempMaq(Estrutura estrutura)        // S
        {
            var db = new ApplicationDbContext();
            string tpItmCst = $"{estrutura.TpItmCst}{Global.Space20}";
            float result = tpItmCst.Substring(0, 5) == "c-MOD"
                ? estrutura.QtEftvUntrCmpnt / db.Operacoes.Single(o => o.CodigoOperacao == estrutura.Item).TaxaOcupacao
                : 0;

            return result;
        }

        public static int QtdUndd(Estrutura estrutura)
        {
            return estrutura.Produto.QtdUnid;

        }

        public static float PsLiqdFnl(Estrutura estrutura)      // U
        {
            
            var db = new ApplicationDbContext();
            string unidade = db.Unidades.Single(u => u.UnidadeId == estrutura.UnidadeCompraId).Apelido;
            float result = Math.Abs(estrutura.QtdCusto) 
                > Global.Tolerance 
                && estrutura.Sequencia.Tipo == "A" 
                && unidade == "kg"
                ? estrutura.Lote / estrutura.QtdCusto
                : 0;

            return result;
        }

        public static float PesoLiqPrec(Estrutura estrutura)    // V
        {
            var db = new ApplicationDbContext();
            float result = 0;
            string sequencia = XmlReader.Read("SequenciaA");
            string unidade = db.Unidades.Single(u => u.UnidadeId == estrutura.UnidadeCompraId).Apelido;

            if (estrutura.Sequencia.Tipo == sequencia
                && estrutura.TpItmCst == XmlReader.Read("Manufaturado")
                && unidade != "kg")
            {
                var produto = db.Estruturas.Where(e => e.Produto.Apelido == estrutura.Item);
                if (produto.Any() && (Math.Abs(estrutura.QtdCusto) > Global.Tolerance) )
                    result = produto.Sum(e => e.PsLiqdFnl) * estrutura.Lote / estrutura.QtdCusto;
            }

            return result;
        }

        public static float HrsModFnl(Estrutura estrutura)      // W
        {
            float result = Math.Abs(estrutura.QtdCusto) > Global.Tolerance
                && estrutura.Sequencia.Tipo.Substring(0, 1) == XmlReader.Read("SequenciaE1").Substring(0, 1)
                ? estrutura.QtEftvUntrCmpnt
                : 0;

            return result;
        }

        public static float HrsModPrec1(Estrutura estrutura)        // X
        {
            var db = new ApplicationDbContext();
            var boh = estrutura.Produto.Apelido;
            var mah = estrutura.Item;
            float result = estrutura.TpItmCst == XmlReader.Read("Manufaturado") && estrutura.Onera
                ? db.Produtos.Single(p => p.Apelido == estrutura.Item).HorasModUltmEtapa * estrutura.QtEftvUntrCmpnt
                : 0;

            return result;
        }

        public static float HrsModPrec2(Estrutura estrutura)        // Y
        {
            var db = new ApplicationDbContext();
            float result = estrutura.TpItmCst == XmlReader.Read("Manufaturado") && estrutura.Onera
                ? db.Produtos.Single(p => p.Apelido == estrutura.Item).HorasModEtapa1 * estrutura.QtEftvUntrCmpnt
                : 0;

            return result;
        }

        public static string IdProd(Estrutura estrutura)        // Z
        {
            var db = new ApplicationDbContext();
            var produto = db.Produtos.SingleOrDefault(p => p.Id == estrutura.ProdutoId);

            if (produto == null)
            {
                DbLogger.Log(Reason.Error,$"Erro: Produto {estrutura.ProdutoId} não encontrado");
                return "Erro";
            }

            var unidade = db.Unidades.Single(u => u.UnidadeId == estrutura.UnidadeId);
            return $"{produto.Descricao}-{produto.Apelido}-{unidade.Apelido}";
        }

        public static string IdCmpnt(Estrutura estrutura)       // AA
        {
            var db = new ApplicationDbContext();
            string unidade = db.Unidades.Single(u => u.UnidadeId == estrutura.UnidadeCompraId).Apelido;

            return $"{estrutura.Item}-{estrutura.DescCompProc}-{unidade}";
        }

        public static float PdrHoraria(Estrutura estrutura)     // AB
        {
            float result = 0;

            if (estrutura.Sequencia.Tipo.Substring(0, 1) == XmlReader.Read("SequenciaE1").Substring(0, 1))
            {
                if (Math.Abs(estrutura.Lote) > Global.Tolerance)
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
            float quantidade = db.Produtos.Single(p => p.Apelido == estrutura.Produto.Apelido).QtdUnid;
            float result = float.MaxValue;
            if (Math.Abs(quantidade) > Global.Tolerance) result = estrutura.CstCmprUndPrd / quantidade;

            return result;
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