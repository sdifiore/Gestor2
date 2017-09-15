namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_proicmsub")]
    public partial class base_proicmsub
    {
        [Key]
        public int IDSUBST { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODICM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ESTADO { get; set; }

        public decimal ICMSINTERNO { get; set; }

        public decimal ICMSESTADO { get; set; }

        public decimal REDUCAOESTADO { get; set; }

        public decimal MARGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string SUBST { get; set; }

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
