namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.nfe_municipio_ibge")]
    public partial class nfe_municipio_ibge
    {
        public int ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODUF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string UF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string NOMEUF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODMESO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string NOMEMESO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODMICRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string MICRONOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODMUN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string MUNNOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODDISTR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string DISTRNOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODSUBDISTR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string SUBDISTRNOME { get; set; }

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
