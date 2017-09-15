namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_profisc_ufxst")]
    public partial class base_profisc_ufxst
    {
        [Key]
        public int IDUFXST { get; set; }

        public int IDPES_ORIGEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string UFORIGEM { get; set; }

        public int IDPES_DESTINO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string UFDESTINO { get; set; }

        [Required]
        [StringLength(999)]
        public string OPERACAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMS_CNF { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(15)]
        public string CODCLFISCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string USARFATORCNV_PAUTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CALCDIFALIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ICMS_RBASECOD { get; set; }

        public decimal MLUCRO { get; set; }

        public decimal PRECOMIN { get; set; }

        public decimal? ALIQ_ST { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LIBERA_LISTANEG { get; set; }

        public decimal PRECOMIN_IPI { get; set; }

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
