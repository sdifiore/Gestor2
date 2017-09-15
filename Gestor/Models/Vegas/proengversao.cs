namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proengversao")]
    public partial class proengversao
    {
        [Key]
        public int IDENGVERSAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string PRODGRADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string ENGGRADE { get; set; }

        [Column(TypeName = "date")]
        public DateTime CRIA_DT { get; set; }

        public int CRIA_RESP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? APROV_DT { get; set; }

        public int? APROV_RESP { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(200)]
        public string TITULO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string EFETIVIDADE { get; set; }

        [StringLength(16777215)]
        public string INFO_GERAL { get; set; }

        [StringLength(16777215)]
        public string OBJETIVO { get; set; }

        [StringLength(16777215)]
        public string APLICABILIDADE { get; set; }

        [StringLength(16777215)]
        public string INSTR_GERAL { get; set; }

        [StringLength(16777215)]
        public string PUBL_AFETADAS { get; set; }

        [StringLength(16777215)]
        public string INFO_MO { get; set; }

        [StringLength(16777215)]
        public string MOTIVO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PUBLICA_DT { get; set; }

        public DateTime? PUBLICA_MOM { get; set; }

        public int? PUBLICA_RESP { get; set; }

        [StringLength(16777215)]
        public string PUBLICA_OBS { get; set; }

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
