namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_comunica")]
    public partial class os_comunica
    {
        [Key]
        public Guid IDCOMUNICA { get; set; }

        public Guid OS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string EVENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODPERIOD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODMEIO { get; set; }

        [StringLength(16777215)]
        public string DOCUMENTOS { get; set; }

        public int? RESPONSAVEL { get; set; }

        [StringLength(999)]
        public string PAPEL { get; set; }

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
