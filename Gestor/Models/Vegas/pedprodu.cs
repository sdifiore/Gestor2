namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pedprodu")]
    public partial class pedprodu
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPRODU { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDPEDIDO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string REFERENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CODUNIVERS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal QTD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal DESC_VALOR { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal DESC_PERC { get; set; }

        [StringLength(16777215)]
        public string DESC_FISC_MC { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal VALORTOT { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal VALORREF { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal CUSTXFATOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTPREVENTR { get; set; }

        [StringLength(16777215)]
        public string DETALHE { get; set; }

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

        public decimal? VALCONTABIL { get; set; }

        public decimal? ICMS_BASE { get; set; }

        public decimal? ICMS_VAL { get; set; }

        public decimal? ICMS_ISENTO { get; set; }

        public decimal? ICMS_OUTROS { get; set; }

        public decimal? ICMS_B_SUB { get; set; }

        public decimal? ICMSUB_VAL { get; set; }

        public decimal? ICMS_V_CIAP { get; set; }

        public decimal? ICMS_V_STRET { get; set; }

        public decimal? ICMS_ESPE_VALOR { get; set; }

        public decimal? ICMS_ESPE_ISENTO { get; set; }

        public decimal? ICMS_ESPE_OUTROS { get; set; }

        public decimal? ICMS_ESPE_V_SUB { get; set; }

        public decimal? IPI_VAL { get; set; }

        public decimal? IPI_ISENTO { get; set; }

        public decimal? IPI_OUTROS { get; set; }

        public decimal? IPI_V_RECUP { get; set; }

        public decimal? IPI_ESPE_VALOR { get; set; }

        public decimal? IPI_ESPE_ISENTO { get; set; }

        public decimal? IPI_ESPE_OUTROS { get; set; }

        public decimal? PIS_VALOR { get; set; }

        public decimal? PIS_ESPE_VALOR { get; set; }

        public decimal? COFINS_VALOR { get; set; }

        public decimal? COFINS_ESPE_VALOR { get; set; }

        public decimal? ISS_VAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ISS_RETER { get; set; }

        public decimal? INSS_VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string INSS_RETER { get; set; }

        public decimal? IR_VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string IR_RETER { get; set; }

        public decimal? II_DESPADUANEIRA { get; set; }

        public decimal? II_VALOR { get; set; }

        public decimal? II_IOF { get; set; }

        [StringLength(16777215)]
        public string FISC_INFOS { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal VALORRAT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 13, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
