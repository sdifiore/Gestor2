namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.op_linksubpro")]
    public partial class op_linksubpro
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDLINKSUBPRO { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDMISUBPROD { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid IDMIPROD { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal QTDESTRU { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal FATOR_CUSTO { get; set; }

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

        [Key]
        [Column("_UCRC_", Order = 6, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
