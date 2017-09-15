namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.roturno")]
    public partial class roturno
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDROT { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LANCAMENTO { get; set; }

        public int? RESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TPTURNO { get; set; }

        public DateTime? MOM_ABERTURA { get; set; }

        public DateTime? MOM_FECHA { get; set; }

        public int? RESP_FECHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TPFECHA { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }
    }
}
