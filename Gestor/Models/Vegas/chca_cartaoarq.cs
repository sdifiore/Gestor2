namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.chca_cartaoarq")]
    public partial class chca_cartaoarq
    {
        [Key]
        public int IDCARTAOARQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string NOMEARQ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string OPERADORA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }
    }
}
