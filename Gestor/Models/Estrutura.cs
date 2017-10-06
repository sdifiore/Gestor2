using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestor.Models
{
    public class Estrutura
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Display(Name = "Código do Produto")]
        public string Apelido { get; set; }

        [Display(Name = "Código")]
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Código")]
        public Produto Produto { get; set; }

        public bool Onera { get; set; }

        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        public int SequenciaId { get; set; }

        [Display(Name = "Sequência")]
        public Sequencia Sequencia { get; set; }
    }
}