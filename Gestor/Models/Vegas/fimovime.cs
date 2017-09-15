namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.fimovime")]
    public partial class fimovime
    {
        [Key]
        public int IDMOVIME { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ST2 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CONTA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPODOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DOCUMENTO { get; set; }

        public decimal VALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(65)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AUXILIAR { get; set; }

        public int? PESSOA { get; set; }

        public int? RESPONSA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LIQUIDA { get; set; }

        public DateTime? CONCILIA { get; set; }

        public decimal? REF_VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string REF_INDIC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [StringLength(16777215)]
        public string OBSERVA { get; set; }

        [StringLength(16777215)]
        public string OBSERVAAUX { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string LIGATAB { get; set; }

        public Guid? LIGAID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string RATEIO { get; set; }

        public decimal VALORRAT { get; set; }

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
