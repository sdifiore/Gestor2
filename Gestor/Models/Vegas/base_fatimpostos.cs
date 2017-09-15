namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_fatimpostos")]
    public partial class base_fatimpostos
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODIMPOSTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        public decimal ALIQUOTA { get; set; }

        public decimal LIMITE { get; set; }

        public decimal REDUCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ACUMULA { get; set; }

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
