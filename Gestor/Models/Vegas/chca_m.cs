namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.chca_m")]
    public partial class chca_m
    {
        [Key]
        public int IDCHCA { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATAMOV { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOMOV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AUXILIAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BANDEIRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BANCO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string AGENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NUMERO { get; set; }

        public decimal VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREDATA { get; set; }

        public int? PARCELA { get; set; }

        public int? PARCTOT { get; set; }

        public int? PESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CNPJ_CPF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string IE_RG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ST2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONTACORRE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BAIXADATA { get; set; }

        public decimal BAIXAVALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSUAR { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXATIPO { get; set; }

        public decimal TAXA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODDEV { get; set; }

        public DateTime? MOMDEV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string ORIGLOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGTAB { get; set; }

        public Guid? ORIGID { get; set; }

        public decimal VALORRAT { get; set; }

        public int? SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string OPERADOR { get; set; }

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
