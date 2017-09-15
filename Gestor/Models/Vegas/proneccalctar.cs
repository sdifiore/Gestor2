namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proneccalctar")]
    public partial class proneccalctar
    {
        [Key]
        public int IDCALCTAR { get; set; }

        public int IDNECCALC { get; set; }

        public int IDNECPRIN { get; set; }

        public int IDETRTAREFA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODTAREFA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        public int POSICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AGRUPAMENTO { get; set; }

        public decimal SETUP { get; set; }

        public decimal TEMPO { get; set; }

        public decimal CUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
