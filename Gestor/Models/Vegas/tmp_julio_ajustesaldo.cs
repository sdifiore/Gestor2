namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.tmp_julio_ajustesaldo")]
    public partial class tmp_julio_ajustesaldo
    {
        [Key]
        public int IDTMP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODCONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRCONTA { get; set; }

        public DateTime? ULTMOV { get; set; }

        public decimal? SALDOSIST { get; set; }

        public decimal? SALDOEXTR { get; set; }
    }
}
