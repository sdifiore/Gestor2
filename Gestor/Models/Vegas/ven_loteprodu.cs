namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_loteprodu")]
    public partial class ven_loteprodu
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDPRODU { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(9)]
        public string LOTE { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal QTDE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ACRESCIMO { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal DESCONTO { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal VALORTOTAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 9, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
