using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class DetalheProduto
    {
        public int DetalheProdutoId { get; set; }

        [Display(Name = "Peso Líquido")]
        public float PesoLiquido { get; set; }

        [Display(Name = "Itens de Estrutura")]
        public int ItemStrut { get; set; }

        [Display(Name = "Custo direto / unidade")]
        public float CstDirIndd { get; set; }

        [Display(Name = "Custo mats última etapa")]
        public float CstMtsUltmEtp { get; set; }

        [Display(Name = "Custo mats etapa 1")]
        public float CstMtsEtp1 { get; set; }

        [Display(Name = "Custo mats etapa 2")]
        public float CstMtsEtp2 { get; set; }

        [Display(Name = "Custo mats etapa 3")]
        public float CstMtsEtp3 { get; set; }

        [Display(Name = "Custo total mats")]
        public float CstTotMts { get; set; }

        [Display(Name = "Custo direto MOD")]
        public float CstDirMod { get; set; }

        [Display(Name = "Horas MOD ultima etapa")]
        public float HrsMod { get; set; }

        [Display(Name = "Horas MOD etapa 1")]
        public float HrsMod1 { get; set; }

        [Display(Name = "Horas MOD etapa 2")]
        public float HrsMod2 { get; set; }

        [Display(Name = "Horas totais MOD")]
        public float HrsTotMod { get; set; }

        [Display(Name = "Capacidade Prod Horária")]
        public float CpcdProdHrr { get; set; }

        [Display(Name = "Lote mínimo")]
        public int LoteMin { get; set; }

        [Display(Name = "Uso Estrutura")]
        public float UsoStrut { get; set; }

        [Display(Name = "Custo Dir R$/Kg")]
        public float CstDirRgKg { get; set; }

        [Display(Name = "Rel MOD/Custo")]
        public float RelModCst { get; set; }

        [Display(Name = "% mats final")]
        public float PctMtrFnl { get; set; }

        [Display(Name = "% mats etapa 1")]
        public float PctMtrEtp1 { get; set; }

        [Display(Name = "% mats etapa 2")]
        public float PctMtrEtp2 { get; set; }

        [Display(Name = "% mats etapa 3")]
        public float PctMtrEtp3 { get; set; }

        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }
    }
}