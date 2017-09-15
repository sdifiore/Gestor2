namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_parc")]
    public partial class ven_parc
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDPARC { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDSEQ { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UUIDPEDIDO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PARCELA { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PARCTOT { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "date")]
        public DateTime VENCIMENTO { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "char")]
        [StringLength(9)]
        public string TIPODOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BANCO { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal DESCONTO { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal JUROS { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal OUTROS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DOCUMENTO { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal VALORTOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONVENIO { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BAIXADATA { get; set; }

        public decimal? BAIXAVALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSUAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string BAIXATIPO { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRAZO { get; set; }

        public int? IDCOBRA { get; set; }

        public int? IDRECEBER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DOCFIXO { get; set; }

        [Key]
        [Column("_UCRC_", Order = 14, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
