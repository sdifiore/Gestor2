using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestor.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Display(Name ="Código")]
        public string Codigo { get; set; }

        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [StringLength(10)]
        public string Unidade { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        [StringLength(2)]
        [Display(Name = "Classe de Custo")]
        public string ClasseCusto { get; set; }

        [StringLength(2)]
        public string Categoria { get; set; }

        [StringLength(3)]
        [Display(Name = "Família")]
        public string Familia { get; set; }

        [StringLength(4)]
        public string Linha { get; set; }
    }
}