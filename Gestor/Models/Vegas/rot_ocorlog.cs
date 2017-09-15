namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.rot_ocorlog")]
    public partial class rot_ocorlog
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDLOG { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LANCAMENTO { get; set; }

        public Guid IDOCOR { get; set; }

        public Guid? IDPROV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DETALHE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string STATUS_ANT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string STATUS_NOVO { get; set; }
    }
}
