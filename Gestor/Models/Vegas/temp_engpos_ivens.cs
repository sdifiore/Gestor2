namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_engpos_ivens")]
    public partial class temp_engpos_ivens
    {
        [Key]
        public int IDLANC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PRODGRADE { get; set; }

        public decimal? IDENGVERSAO { get; set; }
    }
}
