namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.equocorr")]
    public partial class equocorr
    {
        [Key]
        public int IDEQPOCOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        public int? IDEQUIPA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        public int? RESPONSA { get; set; }

        [StringLength(16777215)]
        public string DETALHE { get; set; }

        public Guid? ID_OS { get; set; }

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
