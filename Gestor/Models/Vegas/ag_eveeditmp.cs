namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ag_eveeditmp")]
    public partial class ag_eveeditmp
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDAEVEEDITMP { get; set; }

        [StringLength(16777215)]
        public string DETALHE { get; set; }

        [StringLength(16777215)]
        public string ADICIONADO { get; set; }

        [Key]
        [Column("_UCRC_", Order = 1, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
