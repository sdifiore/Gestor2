namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_ativrec")]
    public partial class os_ativrec
    {
        [Key]
        public Guid IDATIVREC { get; set; }

        public Guid IDATIVIDADE { get; set; }

        public int? IDRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PAPEL { get; set; }
    }
}
