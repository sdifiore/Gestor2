namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_gerindice")]
    public partial class base_gerindice
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDINDICE { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(9)]
        public string CODINDICADOR { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAINI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAFIN { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal FAIXAMIN { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal FAIXAMAX { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CENTROCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string TAG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 6, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
