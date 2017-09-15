namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.contxgrupo")]
    public partial class contxgrupo
    {
        [Key]
        public int IDGRUPO { get; set; }

        public int IDCONTRATO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string GRUPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FIM { get; set; }

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
