using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class Embalagem
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}