namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.tg_log_generico")]
    public partial class tg_log_generico
    {
        [Key]
        public int IDLOGGEN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODTAREFA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string ID_CONTR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(120)]
        public string VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string STATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }
    }
}
