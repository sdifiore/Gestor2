namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_recexprcalc")]
    public partial class os_recexprcalc
    {
        [Key]
        public Guid UUIDEXPRCALC { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODRECURSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string PLAN_TPFATOS { get; set; }

        [StringLength(16777215)]
        public string PLAN_EXPR_CALC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string REAL_TPFATOS { get; set; }

        [StringLength(16777215)]
        public string REAL_EXPR_CALC { get; set; }

        public Guid? IDOS { get; set; }

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
