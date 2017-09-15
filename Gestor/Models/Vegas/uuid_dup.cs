namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.uuid_dup")]
    public partial class uuid_dup
    {
        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(9)]
        public string ORIGEM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime CNSCADMOM { get; set; }
    }
}
