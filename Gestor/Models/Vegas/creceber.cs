namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.creceber")]
    public partial class creceber
    {
        [Key]
        public int IDRECEBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        public int PESSOA { get; set; }

        public int? IDCONTRATO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPODOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DOCUMENTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AUXILIAR { get; set; }

        [Column(TypeName = "date")]
        public DateTime VENCIMENTO { get; set; }

        public int? PARCELA { get; set; }

        public int? PARCTOT { get; set; }

        public decimal VALOR { get; set; }

        public decimal DESCONTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PRAZODESC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ST2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONTA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAPREV { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        public DateTime? EMISSAO { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BAIXADATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSUAR { get; set; }

        public decimal BAIXAVALOR { get; set; }

        public decimal JUROS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BAIXATIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BAIXATPDOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string BAIXADOC { get; set; }

        public decimal? REF_VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string REF_INDIC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONVCOBR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CFOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string COBRA_CATEG { get; set; }

        public int? IDFATVENC { get; set; }

        public int? IDMOVIMENT { get; set; }

        public int? SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string ORIGTAB { get; set; }

        public Guid? ORIGID { get; set; }

        public decimal VALORRAT { get; set; }

        public int? ORIGRENEG { get; set; }

        public int? RENEGPARC { get; set; }

        public decimal? RENEGDESCONTO { get; set; }

        public decimal? RENEGJUROS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column("_JUROS")]
        public decimal C_JUROS { get; set; }

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
