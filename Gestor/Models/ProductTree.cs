using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class ProductTree
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Codigo { get; set; }

        [StringLength(10)]
        public string ProdutoId { get; set; }

        [StringLength(2)]
        public string Unidade { get; set; }

        [StringLength(2)]
        public string Sequencia { get; set; }

        public float? QuantitadeCusto { get; set; }

        public byte? ClasseCusto { get; set; }

        public string Observacao { get; set; }
    }
}