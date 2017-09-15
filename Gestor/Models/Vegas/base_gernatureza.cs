namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_gernatureza")]
    public partial class base_gernatureza
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CODNAT { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string OPERFISCAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string OPERTIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string FLUXO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string MOVESTOQUE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string OPERFORMA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string MOVFINAN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string NFCOMPL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string OPERCOMPL { get; set; }

        [StringLength(16777215)]
        public string OBSNF { get; set; }

        public int? BASELEGAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMS_CNF { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMS_CALC { get; set; }

        public decimal ICMS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ICMS_CODREDU { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string ICMS_SUBSTRIB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ICMS_MOTDESONERA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string IPI_CNF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string IPI_CST_ENTRADA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string IPI_CENQ_ENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string IPI_CST_SAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string IPI_CENQ_SAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PISCOFINS_CALC { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string PIS_CNF { get; set; }

        public Guid? PIS_NATBCCRED_E { get; set; }

        public Guid? PIS_NATRECEITA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PIS_IPIBASE { get; set; }

        public decimal? PIS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string COF_CNF { get; set; }

        public Guid? COF_NATBCCRED_E { get; set; }

        [Column(TypeName = "char")]
        [StringLength(126)]
        public string COF_NATRECEITA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string COF_IPIBASE { get; set; }

        public decimal? COFINS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ISS_CNF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP_INTERNO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP_INTESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP_EXTERIOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CSLL_CNF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CODIGO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string INSS_CNF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MOVIMENTA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string IR_CNF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string IPI_APLIC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string IPI_RECUP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSPADRAO { get; set; }

        [StringLength(16777215)]
        public string CNSAJUDA { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
