namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.profisc_servxufxcl")]
    public partial class profisc_servxufxcl
    {
        [Key]
        public int IDRETENCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODMUN { get; set; }

        public int? IDPESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string ISS_CNF { get; set; }

        public decimal ISS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string PIS_CNF { get; set; }

        public decimal PIS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string COFINS_CNF { get; set; }

        public decimal COFINS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string CSLL_CNF { get; set; }

        public decimal CSLL_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string INSS_CNF { get; set; }

        public decimal INSS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string IR_CNF { get; set; }

        public decimal IR_ALIQ { get; set; }

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
