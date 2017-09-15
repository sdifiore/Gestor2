namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prolgmv")]
    public partial class prolgmv
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDLOG { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDLOGSEQ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string TIPOMOV { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal QUANTIDADE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal QTDANT { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODUTOPAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ORIGEMLOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal VALORTOT { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal RATEIO { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal CUSTOTOT { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal CUSTOGERTOT { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal PESO_BRUTO { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal PESO_LIQUI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 15, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
