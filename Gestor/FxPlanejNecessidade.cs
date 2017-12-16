using Gestor.Models;
using System.Linq;

namespace Gestor
{
    public static class FxPlanejNecessidade
    {
        public static string SetorProducao(Estrutura stru)     // T
        {
            string result = "";

            if (stru.SetorProducao.Substring(0, 5) == "c-MOD")
            {
                var db = new ApplicationDbContext();
                var operacao = db.Operacoes.SingleOrDefault(o => o.CodigoOperacao == stru.Item);
                if (operacao != null) result = operacao.SetorProducao;
            }

            return result;
        }
    }
}