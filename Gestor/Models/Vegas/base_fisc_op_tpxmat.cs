namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_fisc_op_tpxmat")]
    public partial class base_fisc_op_tpxmat
    {
        [Key]
        public int IDOPXCLAS { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string OPTIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CLFIMAT { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string FLUXO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string FIS_JUR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMS_CNF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP_INTERNO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP_INTESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP_EXTERIOR { get; set; }

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
