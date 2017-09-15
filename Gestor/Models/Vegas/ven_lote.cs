namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_lote")]
    public partial class ven_lote
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODLOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATAINI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAFIN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string GRUPRECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ACAOMKT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime DTLANCAMENTO { get; set; }

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
