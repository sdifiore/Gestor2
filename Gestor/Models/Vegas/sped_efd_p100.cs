namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sped_efd_p100")]
    public partial class sped_efd_p100
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDREG { get; set; }

        public Guid? UIDREGPAI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FIN { get; set; }

        public decimal? VL_REC_TOT_EST { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string COD_ATIV_ECON { get; set; }

        public decimal? VL_REC_ATIV_ESTAB { get; set; }

        public decimal? VL_EXC { get; set; }

        public decimal? VL_BC_CONT { get; set; }

        public decimal? ALIQ_CONT { get; set; }

        public decimal? VL_CONT_APU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string COD_CTA { get; set; }

        [StringLength(16777215)]
        public string INFO_COMPL { get; set; }

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
