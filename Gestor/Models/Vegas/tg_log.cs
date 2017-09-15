namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.tg_log")]
    public partial class tg_log
    {
        [Key]
        public int IDLOG { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODTAREFA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        public int TEMPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OK { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }
    }
}
