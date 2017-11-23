using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class IcmsFrete
    {
        public int Id { get; set; }

        [StringLength(16)]
        [Display(Name = "Rótulo")]
        public string Rotulo { get; set; }

        [Display(Name = "ICMS")]
        public float Icms { get; set; }

        [Display(Name = "Frete")]
        public float Frete { get; set; }
    }
}