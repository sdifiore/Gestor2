namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.propcven")]
    public partial class propcven
    {
        [Key]
        public int IDPRVENDA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string TITULO { get; set; }

        public decimal? MARGEM { get; set; }

        public decimal VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPPREC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODGRUPREC { get; set; }

        public decimal PORCENTO { get; set; }

        public DateTime? ALTPRECO { get; set; }

        public int CASADECIMA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FACILTROCO { get; set; }

        public DateTime? MOMINI { get; set; }

        public DateTime? MOMFIN { get; set; }

        public TimeSpan? HORAINI { get; set; }

        public TimeSpan? HORAFIN { get; set; }

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
