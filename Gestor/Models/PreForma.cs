using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class PreForma
    {
        public int Id { get; set; }

        [Display(Name = "Pré Forma n°")]
        public int PreFormaNum { get; set; }

        [Display(Name = "Forma - ØE mm")]
        public int FormaDiamE { get; set; }

        [Display(Name = "Vareta - ØI mm")]
        public int VaretaDiamI { get; set; }

        public int MedidaFitaId { get; set; }

        public MedidaFita MedidaFita { get; set; }

        [Display(Name = "Comprimento mm")]
        public int Comprimento { get; set; }

        [Display(Name = "T.U.P. min")]
        public int Tup { get; set; }

        [Display(Name = "Prensa Pré-Forma")]
        [StringLength(8)]
        public int PrensaPreForma { get; set; }

        [Display(Name = "Preparo (min)")]
        public int Preparo { get; set; }

        [Display(Name = "Troca PF (min)")]
        public int TrocaPf { get; set; }
    }
}