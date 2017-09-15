namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.mp_monitregs")]
    public partial class mp_monitregs
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDMONITREGS { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDMONITPROC { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(20)]
        public string CODMONITCONF { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(40)]
        public string CODAVALIA { get; set; }

        public decimal? VALOR_N { get; set; }

        public DateTime? VALOR_M { get; set; }

        [StringLength(16777215)]
        public string VALOR_C { get; set; }

        public decimal? TEMPO_S { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 5, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
