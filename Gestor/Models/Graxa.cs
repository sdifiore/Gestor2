using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class Graxa
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Display(Name = "Código")]
        public string Apelido { get; set; }

        [StringLength(100)]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        
    }
}