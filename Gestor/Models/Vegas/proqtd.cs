namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proqtd")]
    public partial class proqtd
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDQTD { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal QTD { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal PESO_BRUTO { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal PESO_LIQUI { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal CUSTO { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal CUSTO_GER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FABRICACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_VALIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string CNSHASHMD5 { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 11, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
