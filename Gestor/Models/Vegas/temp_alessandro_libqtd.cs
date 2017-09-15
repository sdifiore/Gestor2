namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_alessandro_libqtd")]
    public partial class temp_alessandro_libqtd
    {
        [Key]
        public int IDLAN { get; set; }

        public Guid? UUIDPRODU { get; set; }

        public decimal? QTDLIB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREVISAO { get; set; }
    }
}
