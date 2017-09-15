namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sped_efd_0145")]
    public partial class sped_efd_0145
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDREG { get; set; }

        public Guid? UIDPROC { get; set; }

        public int? COD_INC_TRIB { get; set; }

        public decimal? VL_REC_TOT { get; set; }

        public decimal? VL_REC_ATIV { get; set; }

        public decimal? VL_REC_DEMAIS_ATIV { get; set; }

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
