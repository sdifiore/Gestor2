using Gestor.Models;
using System.Linq;

namespace Gestor
{
    public static class FxPlanejNecessidade
    {
        public static string SetorProducao(Estrutura stru)     // T
        {
            string result = "";

            if (stru.TpItmCst != null)
            {
                string comp = $"{stru.TpItmCst}{Global.Space5}".Substring(0, 5);

                if (comp == "c-MOD")
                {
                    var db = new ApplicationDbContext();
                    var operacao = db.Operacoes.SingleOrDefault(o => o.CodigoOperacao == stru.Item);
                    if (operacao != null) result = operacao.SetorProducao;
                } 
            }

            return result;
        }

        public static string Categoria(Estrutura stru)      // U
        {
            string result = "";
            var db = new ApplicationDbContext();

            if (stru.TpItmCst == XmlReader.Read("Manufaturado"))
            {
                var produto = db.Produtos.SingleOrDefault(p => p.Apelido == stru.Item);
                if (produto != null)
                {
                    int id = produto.CategoriaId;
                    var categoria = db.Categorias.SingleOrDefault(c => c.CategoriaId == id);
                    if (categoria != null) result = categoria.Descricao;
                }
            }

            else
            {
                if (stru.TpItmCst == XmlReader.Read("Insumos"))
                {
                    var insumo = db.Insumos.SingleOrDefault(i => i.Apelido == stru.Item);
                    if (insumo != null)
                    {
                        int id = insumo.CategoriaId;
                        var categoria = db.Categorias.SingleOrDefault(c => c.CategoriaId == id);
                        if (categoria != null) result = categoria.Descricao;
                    }
                }
            }

            return result;
        }

        public static float ListaPlanejProducao(Estrutura stru)     // W
        {
            // ***************** Deve-se primeiramente calcular PlanejProdução

            return 0;
        }
    }
}