namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.patrimonio")]
    public partial class patrimonio
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPATRI { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(12)]
        public string BPI { get; set; }

        public int? IDRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOCALIZACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string MARCA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string MODELO { get; set; }

        public int? FORNECEDOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DOCUMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string SN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AQUISDATA { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal AQUISVALOR { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal AQUISDOLAR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENDADATA { get; set; }

        public decimal? VENDAVALOR { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal VENDADOLAR { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

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

        [Key]
        [Column(Order = 6, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 7, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
