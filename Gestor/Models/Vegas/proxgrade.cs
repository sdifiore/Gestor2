namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proxgrade")]
    public partial class proxgrade
    {
        [Key]
        public int IDPROXGRADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string ESTRGRADE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PUBLICA_DT { get; set; }

        public DateTime? PUBLICA_MOM { get; set; }

        public int? PUBLICA_RESP { get; set; }

        [StringLength(16777215)]
        public string PUBLICA_OBS { get; set; }

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
