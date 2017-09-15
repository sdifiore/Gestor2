namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proctrest")]
    public partial class proctrest
    {
        [Key]
        public int IDCONTROLE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODLOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODGRADE { get; set; }

        public decimal LOTEECON { get; set; }

        public decimal LOTEMULT { get; set; }

        public decimal PONTOPED { get; set; }

        public decimal ESTMINIMO { get; set; }

        public decimal ESTMAXIMO { get; set; }

        public decimal ESTSEGU { get; set; }

        public int RESUPRI { get; set; }

        public int TMPPED { get; set; }

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
