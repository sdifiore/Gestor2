using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class IndiceRateioLucratividade
    {
        public int Id { get; set; }

        [Display(Name = "Grupo de Rateio")]
        public int GrupoRateioId { get; set; }

        public GrupoRateio GrupoRateio { get; set; }

        [Display(Name = "Total Custos Fixos")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float TotalCustoFixo { get; set; }

        [Display(Name = "MOI de Fabricação")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float MoiFabricacao { get; set; }

        [Display(Name = "Outros Custos Fixos Fabricação")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float OutroCustoFixoFabricacao { get; set; }

        [Display(Name = "Custo Fixo COMACS")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CustoFixoComacs { get; set; }

        [Display(Name = "Custo Fixo COMTEX")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CustoFixoComtex { get; set; }

        [Display(Name = "Custo Fixo Admin Log")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float CustoFixoAdminLog { get; set; }
    }
}