namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.un_pesqinfo")]
    public partial class un_pesqinfo
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(20)]
        public string IDPESQINFO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string IDPESQUISA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string PERGUNTA { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string HINT { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string TIPODADO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string BANDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OBRIGATORIO { get; set; }

        public int? TAMANHO { get; set; }

        public int? DECIMAIS { get; set; }

        [StringLength(16777215)]
        public string ESTRUTURA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string MASCARA { get; set; }

        [StringLength(16777215)]
        public string VALID { get; set; }

        [StringLength(16777215)]
        public string VLDEFAULT { get; set; }

        [StringLength(16777215)]
        public string INTERROGA { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string MULTIPLA_ESCOLHA { get; set; }

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
