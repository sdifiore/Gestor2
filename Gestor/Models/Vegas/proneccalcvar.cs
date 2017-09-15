namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proneccalcvar")]
    public partial class proneccalcvar
    {
        [Key]
        public int IDCALCVAR { get; set; }

        public int IDNECCALC { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODTPVARIACAO { get; set; }

        [StringLength(16777215)]
        public string VALORVARIACAO { get; set; }

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
