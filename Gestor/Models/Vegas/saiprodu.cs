namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.saiprodu")]
    public partial class saiprodu
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPRODU { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDPROSEQ { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid IDSAIDA { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODPAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(150)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string REFERENCIA { get; set; }

        public int? EQUIPAMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOAGENDA { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal QTD { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal DESC_VALOR { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal DESC_PERC { get; set; }

        [StringLength(16777215)]
        public string DESC_FISC_MC { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal VALORTOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CLFISCAL_COD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODORIGEM { get; set; }

        public decimal? VALCONTABIL { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal ICMS_VAL { get; set; }

        public decimal? ICMS_ISENTO { get; set; }

        public decimal? ICMS_OUTROS { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal ICMSUB_VAL { get; set; }

        public decimal? ICMS_V_CIAP { get; set; }

        public decimal? ICMS_V_STRET { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal IPI_VAL { get; set; }

        public decimal? IPI_ISENTO { get; set; }

        public decimal? IPI_OUTROS { get; set; }

        public decimal? IPI_V_RECUP { get; set; }

        public decimal? PIS_VALOR { get; set; }

        public decimal? COFINS_VALOR { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal ISS_VAL { get; set; }

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

        [StringLength(16777215)]
        public string FISC_INFOS { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal RATEIO { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal GEROUTROS { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal GERRATEIO { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal PESO_BRUTO { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal PESO_LIQUI { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal BAIXA_QTD { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSU { get; set; }

        public int? BAIXARESP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FABRICACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_VALIDADE { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal VALORRAT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 22, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
