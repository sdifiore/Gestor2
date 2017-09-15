namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cobexpmovconf")]
    public partial class cobexpmovconf
    {
        [Key]
        public int IDCONFIG { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODCONV { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string PROCESSO { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
