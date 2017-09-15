namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.fatprodu")]
    public partial class fatprodu
    {
        [Key]
        public int IDPRODU { get; set; }

        public int IDFATURA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        public int? EQUIPAMEN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODIGO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(150)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string COMPLEMENT { get; set; }

        public decimal QTD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        public decimal VALOR { get; set; }

        public decimal VALORITEM { get; set; }

        public decimal DESC_VALOR { get; set; }

        [StringLength(16777215)]
        public string DESC_FISC_MC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CLFISCAL_COD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ICMS_CNF { get; set; }

        public decimal VALCONTABIL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ICMS_BASE_MOD { get; set; }

        public decimal ICMS_BASE_RED { get; set; }

        public decimal ICMS_BASE { get; set; }

        public decimal ICMS_ALIQ { get; set; }

        public decimal ICMS_VALOR { get; set; }

        public decimal ICMS_ISENTO { get; set; }

        public decimal ICMS_OUTROS { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMSST_CEST { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ICMS_B_MOD_SUB { get; set; }

        public decimal ICMS_B_RED_SUB { get; set; }

        public decimal ICMS_B_SUB { get; set; }

        public decimal ICMS_ALIQST { get; set; }

        public decimal ICMS_V_SUB { get; set; }

        public decimal ICMS_B_STRET { get; set; }

        public decimal ICMS_V_STRET { get; set; }

        public decimal ICMS_MG_VALADD_SUB { get; set; }

        public decimal ICMS_B_CIAP { get; set; }

        public decimal ICMS_V_CIAP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ICMS_MOTDESONERA { get; set; }

        public decimal ICMS_ALIQ_SN { get; set; }

        public decimal ICMS_V_SN { get; set; }

        public decimal UFDEST_BC { get; set; }

        public decimal UFDEST_A_INTERNA { get; set; }

        public decimal UFDEST_V_ICMS { get; set; }

        public decimal UFDEST_V_ICMSREMET { get; set; }

        public decimal UFDEST_A_PARTDEST { get; set; }

        public decimal UFDEST_A_FCP { get; set; }

        public decimal UFDEST_V_FCP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string IPI_CST { get; set; }

        public decimal IPI_BASE { get; set; }

        public decimal IPI_ALIQ { get; set; }

        public decimal IPI_VALOR { get; set; }

        public decimal IPI_ISENTO { get; set; }

        public decimal IPI_OUTROS { get; set; }

        public decimal IPI_B_RECUP { get; set; }

        public decimal IPI_V_RECUP { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(3)]
        public string IPI_CENQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string PIS_CNF { get; set; }

        public decimal PIS_BASE { get; set; }

        public decimal PIS_ALIQ { get; set; }

        public decimal PIS_VALOR { get; set; }

        public Guid PIS_NATRECEITA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string PIS_RETER { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string COFINS_CNF { get; set; }

        public decimal COFINS_BASE { get; set; }

        public decimal COFINS_ALIQ { get; set; }

        public decimal COFINS_VALOR { get; set; }

        public Guid COFINS_NATRECEITA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string COFINS_RETER { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ISS_CNF { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODSERVLISTA { get; set; }

        public decimal ISS_BASE { get; set; }

        public decimal ISS_ALIQ { get; set; }

        public decimal ISS_VALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string ISS_RETER { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string ISS_CODTRIBMUN { get; set; }

        public decimal INSS_BASE { get; set; }

        public decimal INSS_ALIQ { get; set; }

        public decimal INSS_VALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string INSS_RETER { get; set; }

        public decimal IR_BASE { get; set; }

        public decimal IR_ALIQ { get; set; }

        public decimal IR_VALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string IR_RETER { get; set; }

        public decimal CSLL_BASE { get; set; }

        public decimal CSLL_ALIQ { get; set; }

        public decimal CSLL_VALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string CSLL_RETER { get; set; }

        public decimal R_DESCONTO { get; set; }

        public decimal R_ACRESCIMO { get; set; }

        public decimal R_FRETE { get; set; }

        public decimal R_SEGURO { get; set; }

        public decimal R_ODESPESAS { get; set; }

        public decimal PESO_BRUTO { get; set; }

        public decimal PESO_LIQUI { get; set; }

        public decimal CIDE_BASE { get; set; }

        public decimal CIDE_ALIQUOTA { get; set; }

        public decimal CIDE_VALOR { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
