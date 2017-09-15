namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os")]
    public partial class o
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDOS { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDOSSEQ { get; set; }

        public Guid? EPPROCESSO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string DESCRESU { get; set; }

        [Column(TypeName = "date")]
        public DateTime DTABERTURA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        public Guid? PROJETO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO { get; set; }

        public int? RESPONSAVEL { get; set; }

        public int? CLIENTE { get; set; }

        public int? CONTRATO { get; set; }

        public int? CONTR_DEDICA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREV_BASE_INI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREV_BASE_FIN { get; set; }

        public decimal PREV_BASE_REC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INIPREV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FINPREV { get; set; }

        public decimal PREV_RECURSO { get; set; }

        public decimal PREV_VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INIREAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FINREAL { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [StringLength(16777215)]
        public string SERVICO { get; set; }

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
        [StringLength(9)]
        public string ABC_OS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }
    }
}
