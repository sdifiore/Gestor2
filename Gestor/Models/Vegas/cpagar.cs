namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cpagar")]
    public partial class cpagar
    {
        [Key]
        public int IDPAGAR { get; set; }

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
        [StringLength(15)]
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

        public decimal JUROS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ST2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONTA { get; set; }

        public int? CODRECEITA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string TPCODBARRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string CODBARRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOPGTOBANC { get; set; }

        public int? CODFORMA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FORMAPGTOBANC { get; set; }

        public int? TIPOCODPGTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODPGTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string BANCOFAV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string AGEFAV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string AGEDACFAV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CONTAFAV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DACFAV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string TIPOCONTAFAV { get; set; }

        public int? ANOBASE { get; set; }

        public int? RENAVAM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string UF { get; set; }

        public int? MUNICIPIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(7)]
        public string PLACA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OPCAOPGTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAPREV { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BAIXADATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSUAR { get; set; }

        public decimal BAIXAVALOR { get; set; }

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

        public int? IDENTRVENC { get; set; }

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
