namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.equipame")]
    public partial class equipame
    {
        [Key]
        public int IDEQUIPA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string MARCA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FAMILIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string MODELO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string SN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PN { get; set; }

        public int? ANO_FABRIC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string FABRICANTE { get; set; }

        public int? ANO_MODELO { get; set; }

        public int? RESPONSA { get; set; }

        public int? FORNECEDOR { get; set; }

        public int? CLIENTE { get; set; }

        public decimal VALOR_REF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        public int? LINKEQUIPA { get; set; }

        [StringLength(16777215)]
        public string DETALHE { get; set; }

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
