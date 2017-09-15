namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gerprnpr")]
    public partial class gerprnpr
    {
        [Key]
        public int IDPRN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODIMPR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string PROCESSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string VISUAL { get; set; }

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
