namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.difw_dicctrl")]
    public partial class difw_dicctrl
    {
        [Key]
        public Guid DICWIN_MD5 { get; set; }

        public DateTime BUILD_MOM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string CHECANDO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string ULTCHK_CADUSU { get; set; }

        public DateTime ULTCHK_CADMOM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(255)]
        public string ULTCHK_MAQUINA { get; set; }
    }
}
