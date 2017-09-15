namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cpagimppgto")]
    public partial class cpagimppgto
    {
        [Key]
        public int IDIMPORTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string FAVNOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FAVCNPJ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string FAVBANCO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string FAVAG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(13)]
        public string FAVCONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(45)]
        public string CODBARRA { get; set; }

        public int? SEUNUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENCIMENTO { get; set; }

        public decimal VALORORIG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAPGTO { get; set; }

        public decimal VALORPGTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string NUMDOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string AUTENTICACAO { get; set; }

        public decimal MULTA { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal VALORLIQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string NOSSONUM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string NOMEARQ { get; set; }

        public int? NUMLOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string SEGMENTO { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string BAIXAUSU { get; set; }

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
