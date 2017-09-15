namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_fisc_baselegal")]
    public partial class base_fisc_baselegal
    {
        [Key]
        public int IDBASE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string TITULO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESC_SCRIPT { get; set; }

        [StringLength(500)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(200)]
        public string OPERACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CODCLFISCAL { get; set; }

        [StringLength(16777215)]
        public string CFOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UFORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UFDESTINO { get; set; }

        public int? IDPESSOA { get; set; }

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
