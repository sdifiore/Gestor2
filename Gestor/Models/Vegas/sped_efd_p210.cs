namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sped_efd_p210")]
    public partial class sped_efd_p210
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDREG { get; set; }

        public Guid? UIDREGPAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string IND_AJ { get; set; }

        public decimal? VL_AJ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string COD_AJ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NUM_DOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DESCR_AJ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_REF { get; set; }

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
