namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ag_agendatmp")]
    public partial class ag_agendatmp
    {
        public int? IDAGTMP { get; set; }

        public Guid? AGENDADO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDAUTO { get; set; }
    }
}
