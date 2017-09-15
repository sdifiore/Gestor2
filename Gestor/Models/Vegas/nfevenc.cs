namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.nfevenc")]
    public partial class nfevenc
    {
        [Key]
        public int IDVENC { get; set; }

        public int IDNFE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPODOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DOCUMENTO { get; set; }

        public decimal VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENCIMENTO { get; set; }

        public decimal DESCONTO { get; set; }

        public int? IDPAGAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PIS_CNF { get; set; }

        public decimal PIS_BASE { get; set; }

        public decimal PIS_ALIQ { get; set; }

        public decimal PIS_VALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string PIS_RETER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string COFINS_CNF { get; set; }

        public decimal COFINS_BASE { get; set; }

        public decimal COFINS_ALIQ { get; set; }

        public decimal COFINS_VALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string COFINS_RETER { get; set; }

        public decimal CSLL_BASE { get; set; }

        public decimal CSLL_ALIQ { get; set; }

        public decimal CSLL_VALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string CSLL_RETER { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

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
