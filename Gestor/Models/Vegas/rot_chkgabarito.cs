namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.rot_chkgabarito")]
    public partial class rot_chkgabarito
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDGB { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LANCAMENTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPCHK { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPTURNO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string HELP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OBRIGA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string TPRESP { get; set; }

        [StringLength(16777215)]
        public string OPCOES { get; set; }

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
