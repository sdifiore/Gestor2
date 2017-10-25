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

            if (register.Sequencia.Descricao != "")
            {
                descCompProc = register.Produto.Descricao;

                if (register.Sequencia.Descricao.Substring(0, 1) == "E")
                {
                    var temp = db.Operacoes.SingleOrDefault(o => o.CodigoOperacao == register.Produto.Apelido);

                    if (temp == null)
                    {
                        DbLogger.Log(Reason.Error, $"Código {register.Item} não encontrado em Estruturas");
                        throw new ApplicationException($"Código {register.Item} não encontrado em Estruturas");
                    }

                    descCompProc = $"Oper. de {db.Operacoes.Single(o => o.CodigoOperacao == register.Item)}";
                } 
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

                var produto = db.Produtos.SingleOrDefault(p => p.Apelido == register.Item);

                if (produto == null)
                {
                    var operacao = db.Operacoes.SingleOrDefault(o => o.CodigoOperacao == register.Item);

                    if (operacao == null)
                    {
                        DbLogger.Log(Reason.Error, $"Código {register.Item} não encontrado em Operações");
                        throw new ApplicationException($"Código {register.Item} não encontrado em Operações");
                    }

                    tipoItemCusto = $"c-MOD Setor {operacao.SetorProducao}";
                }

                else tipoItemCusto = produto.Tipo.Descricao; 
            }

            return tipoItemCusto;
        }

        public static int UnidadeCompraId(Estrutura register, string tpItmCst)      // H
        {
            var db = new ApplicationDbContext();
            int result = db.Unidades.Single(u => u.Descricao == XmlReader.Read("UnidadeNaoInformada")).UnidadeId;

            if (register.Sequencia.Descricao != "")
            {
                if (tpItmCst == XmlReader.Read("Insumos")) result = register.UnidadeId;

                else
                {
                    if (tpItmCst == XmlReader.Read("Manufaturado")) result = register.UnidadeId;

                    else
                    {
                        if (register.Sequencia.Descricao.Substring(0, 1) == XmlReader.Read("SequenciaE1").Substring(0, 1))
                            result = db.Unidades.Single(u => u.Descricao == XmlReader.Read("UnidadeHora")).UnidadeId;
                        else result = db.Unidades.Single(u => u.Descricao == XmlReader.Read("UnidadeUnidade")).UnidadeId;
                    }
                } 
            }

            return result;
        }

        public static float CustoUnitCompra(Estrutura register, string tpItmCst)        // I
        {
            var db = new ApplicationDbContext();
            float result = 0f;

            if (register.Sequencia.Descricao != "")
            {

                if (tpItmCst == XmlReader.Read("Insumos")) result = db.Insumos.Single(i => i.Apelido == register.Item).CustoUndCnsm;
                else
                {
                    /* *************************************
                     * 
                     *  Requer a aba produto
                     *  
                     *  *********************************** */
                }
            }

            return result;
        }
    }
}