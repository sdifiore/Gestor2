namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.respdisp")]
    public partial class respdisp
    {
        [Key]
        public int IDDISP { get; set; }

        public int IDRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODRECURSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string OSTIPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA { get; set; }

        public decimal QTD { get; set; }

        public decimal VALOR { get; set; }

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
