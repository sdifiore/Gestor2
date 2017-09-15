namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sped_efd_p110")]
    public partial class sped_efd_p110
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDREG { get; set; }

        public Guid? UIDREGPAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string NUM_CAMPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string COD_DET { get; set; }

        public decimal? DET_VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string INF_COMPL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 2, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
