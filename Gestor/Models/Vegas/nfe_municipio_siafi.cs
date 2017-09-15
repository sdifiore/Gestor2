namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.nfe_municipio_siafi")]
    public partial class nfe_municipio_siafi
    {
        public int ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNPJ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string MUNICIPIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SIAFI { get; set; }

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
