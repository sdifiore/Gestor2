namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pesregpreench")]
    public partial class pesregpreench
    {
        [Key]
        public int IDDEFFILT { get; set; }

        public int? PES_PESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PES_CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string TABELA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string CAMPO { get; set; }

        [StringLength(16777215)]
        public string VALOR_PADRAO { get; set; }

        [StringLength(16777215)]
        public string VALOR_POSSIV { get; set; }

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
