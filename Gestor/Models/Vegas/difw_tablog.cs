namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.difw_tablog")]
    public partial class difw_tablog
    {
        [Key]
        [Column(Order = 0)]
        public long SEQUENCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UUID { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ORIGEMLOG { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string TIPOLOG { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSSINCHK { get; set; }

        public DateTime? CNSSINMOM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [Required]
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
