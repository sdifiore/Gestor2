using Gestor.Models;
using System.Collections;
using System.Linq;

namespace Gestor
{
    public static class FxProduto
    {
        public static float PesoLiquidoCalc(Produto produto)
        {
            var db = new ApplicationDbContext();
            var estrutura = db.Estruturas;
            var final = estrutura.Where(e => e.Produto.Apelido == produto.Apelido);

            return 0f;
        }
    }
}