namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_ativ_orca")]
    public partial class os_ativ_orca
    {
        [Key]
        public long IDATIVORCA { get; set; }

        public Guid IDATIVIDADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOSERV { get; set; }

        public int? RESPONSAVEL { get; set; }

        public decimal PREV_TEMPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREV_INI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREV_FIN { get; set; }

        public decimal PREVORIG_TEMPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREVORIG_INI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREVORIG_FIN { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }
    }
}
