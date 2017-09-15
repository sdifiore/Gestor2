namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ger_regdesacr")]
    public partial class ger_regdesacr
    {
        [Key]
        public int IDREGRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string PROD_MARCA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string PROD_FAMILIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string PROD_CATEG { get; set; }

        public int? PESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PES_TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PES_CATEG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PES_SEG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PES_ESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PED_TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PED_FORMAPG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PED_TPFRETE { get; set; }

        public decimal VALOR_INI { get; set; }

        public decimal VALOR_FIN { get; set; }

        public int? ORDEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string CUMULATIVO { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal DESC_MAX { get; set; }

        public decimal ACRESCIMO { get; set; }

        public decimal ACRESC_MAX { get; set; }

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
