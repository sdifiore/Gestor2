namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proxcust")]
    public partial class proxcust
    {
        [Key]
        public int IDPROXCUST { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODU { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        public decimal PERCENTUAL { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ACUMULADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FIM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
