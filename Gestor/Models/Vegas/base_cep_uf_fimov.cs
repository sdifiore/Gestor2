namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_cep_uf_fimov")]
    public partial class base_cep_uf_fimov
    {
        [Key]
        public int IDUFFIMOV { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string UFORIGEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string UFDESTINO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CODCLFISCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FLUXO { get; set; }

        public decimal ALIQINT { get; set; }

        public decimal ALIQINTRED { get; set; }

        public decimal ALIQIEST { get; set; }

        public decimal ALIQIESTRED { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ICMS_RBASECOD { get; set; }

        public decimal PAPRECOMIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PADTINI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PADTFIN { get; set; }

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
