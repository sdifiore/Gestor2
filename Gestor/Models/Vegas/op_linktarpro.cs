namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.op_linktarpro")]
    public partial class op_linktarpro
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDLINKTARPRO { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDOPTAR { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid IDMIPROD { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        public decimal? PREVSETUP { get; set; }

        public decimal? PREVTEMPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
