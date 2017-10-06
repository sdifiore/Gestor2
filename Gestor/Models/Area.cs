using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class Area
    {
        public int AreaId { get; set; }

        [StringLength(2)]
        [Display(Name = "Código")]
        public string Apelido { get; set; }

        [StringLength(2)]
        public string Nome { get; set; }
    }
}