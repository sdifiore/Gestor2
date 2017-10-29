using Gestor.Models;

namespace Gestor
{
    public static class FxProduto
    {
        public static float PesoLiquidoCalc(Produto produto)
        {
            var db = new ApplicationDbContext();
            var stru = db.Estruturas;

            return 0f;
        }
    }
}