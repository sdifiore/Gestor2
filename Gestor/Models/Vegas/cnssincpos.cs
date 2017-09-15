namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cnssincpos")]
    public partial class cnssincpos
    {
        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(50)]
        public string DICTABELA { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(50)]
        public string CODIGOAUX { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DICEMPRESA { get; set; }

        public Guid POSICAO { get; set; }

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
