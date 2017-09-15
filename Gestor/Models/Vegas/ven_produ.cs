namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_produ")]
    public partial class ven_produ
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDPRODU { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDPRODU { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UUIDPEDIDO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        public Guid? SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal QTD { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal ACRESCIMO { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal DESCONTO { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal DESC_VALOR { get; set; }

        [StringLength(16777215)]
        public string DESC_FISC_MC { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal VALORITEM { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal VALORTOTAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string GRUPOPRECO { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal RATEIO { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal GERRATEIO { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal GEROUTROS { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal PESO_BRUTO { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal PESO_LIQUI { get; set; }

        [StringLength(16777215)]
        public string DESC_ACRESC_MC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREVISAO { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal FISC_IPI { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal FISC_ICMSUBST { get; set; }

        [StringLength(16777215)]
        public string FISC_INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string NUMPEDCLI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string NUMITEMPEDCLI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal BAIXA_QTD { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal VALORRAT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 21, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
