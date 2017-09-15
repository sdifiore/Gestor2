namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ccfor_m")]
    public partial class ccfor_m
    {
        [Key]
        public int IDMOVIME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOMOVIME { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPODOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DOCUMENTO { get; set; }

        public int PESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public decimal VALOR { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string LIGACAOTAB { get; set; }

        public int? LIGACAOID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DESTTAB { get; set; }

        public int? DESTID { get; set; }

        public DateTime? FECHAMOM { get; set; }

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
