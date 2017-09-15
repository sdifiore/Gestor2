namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_cockpitmater_info_jonas")]
    public partial class temp_cockpitmater_info_jonas
    {
        [Key]
        public int IDLAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public decimal? VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }
    }
}
