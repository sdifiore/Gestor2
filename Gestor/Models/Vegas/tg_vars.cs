namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.tg_vars")]
    public partial class tg_vars
    {
        [Key]
        public int IDVAR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string VAR_NOME { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string VAR_DESC { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODTAREFA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string VAR_TIPO { get; set; }

        [StringLength(16777215)]
        public string VAR_VALOR { get; set; }

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
