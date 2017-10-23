using System.ComponentModel.DataAnnotations;

namespace Gestor.Models
{
    public class DetalheEstrutura
    {
        public int DetalheEstruturaId { get; set; }

        [Display(Name = "Parte no Custo")]
        public float PartCusto { get; set; }

        [Display(Name = "Qt Eff unit comp")]
        public float QtEftvUntrCmpnt { get; set; }

        [Display(Name = "Cst Compr Un Prod")]
        public float CstCmprUndPrd { get; set; }

        [Display(Name = "Tipo Item Custo")]
        public string TpItmCst { get; set; }

        [Display(Name = "Alerta SubProduto")]
        public string AlrtSbPrdt { get; set; }

        [Display(Name = "Tempo máquina")]
        public float TempMaq { get; set; }

        [Display(Name = "Qtd por  Unidade")]
        public int QtdUndd { get; set; }

        [Display(Name = "Peso Liq Final")]
        public float PsLiqdFnl { get; set; }

        [Display(Name = "Peso Liq Precedente")]
        public float PsLiqdPrcdt { get; set; }

        [Display(Name = "Horas Mod Final")]
        public float HrsModFnl { get; set; }

        [Display(Name = "Horas Mod Prec 1")]
        public float HrsModPrec1 { get; set; }

        [Display(Name = "Horas Mod Prec 2")]
        public float HrsModPrec2 { get; set; }

        [Display(Name = "Id Produto")]
        public string IdProd { get; set; }

        [Display(Name = "Id Componente")]
        public string IdCmpnt { get; set; }

        [Display(Name = "Prod Horária")]
        public float PdrHoraria { get; set; }

        [Display(Name = "Prod-comp")]
        public float ProdComp { get; set; }

        [Display(Name = "Cust Material Direto")]
        public float CstMtrlDrt { get; set; }

        [Display(Name = "Cust Material Prec 1")]
        public float CstMtrlPrcd1 { get; set; }

        [Display(Name = "Cust Material Prec 2")]
        public float CstMtrlPrcd2 { get; set; }

        [Display(Name = "Cust Material Prec 3")]
        public float CstMtrlPrcd3 { get; set; }

        public bool Header { get; set; }

        public int EstruturaId { get; set; }

        public Estrutura Estrutura { get; set; }
    }
}