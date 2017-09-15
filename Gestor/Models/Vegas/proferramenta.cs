namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proferramenta")]
    public partial class proferramenta
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODFER { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(45)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(45)]
        public string FABRICANTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(45)]
        public string MODELO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string PN { get; set; }

        [StringLength(16777215)]
        public string APLICAB { get; set; }

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
