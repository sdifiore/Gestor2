using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class FatHistorico
    {
        public int Id { get; set; }

        [Display(Name = "Rótulo")]
        [StringLength(10)]
        public string Rotulo { get; set; }

        [Display(Name = "Fita Receita Líquida")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float FitaRecLiq { get; set; }

        [Display(Name = "Fita Peso")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float FitaPeso { get; set; }

        [Display(Name = "Fita Horas")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float FitaHora { get; set; }

        [Display(Name = "Tubo Receita Líquida")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float TuboRecLiq { get; set; }

        [Display(Name = "Tubo Peso")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float TuboPeso { get; set; }

        [Display(Name = "Tubo Horas")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float TuboHora { get; set; }

        [Display(Name = "GfxPuro Receita Líquida")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GxfPuroRecLiq { get; set; }

        [Display(Name = "GxfPuro Peso")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GxfPuroPeso { get; set; }

        [Display(Name = "GxfPuro Horas")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GxfPuroHora { get; set; }

        [Display(Name = "GxfGraf Receita Líquida")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GxfGrafRecLiq { get; set; }

        [Display(Name = "GxfGra Peso")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GxfGrafPeso { get; set; }

        [Display(Name = "GxfGra Horas")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GxfGrafHora { get; set; }

        [Display(Name = "Graxa Receita Líquida")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GraxaRecLiq { get; set; }

        [Display(Name = "Graxa Peso")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GraxaPeso { get; set; }

        [Display(Name = "Graxa Horas")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public float GraxaHora { get; set; }
    }
}