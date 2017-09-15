namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.firatfil")]
    public partial class firatfil
    {
        [Key]
        public int IDFILTRO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODRATEIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OBRIGATORI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NCONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NPLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NCCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NCLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string ST2 { get; set; }

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
