namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_un_banmot")]
    public partial class base_un_banmot
    {
        [Key]
        public int IDMOTIVO { get; set; }

        public int? IDOCOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODBANCO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(4)]
        public string MOTIVO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

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
