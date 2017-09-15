namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proqtdtmp")]
    public partial class proqtdtmp
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDQTD { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDSEQ { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODUTOPAI { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal QTD { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal VALORUN { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal RATEIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 9, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
