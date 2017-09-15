namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prorec_familrecxrec")]
    public partial class prorec_familrecxrec
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDFAMILRECXREC { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(9)]
        public string CODFAMILIA { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UUIDRECURSO { get; set; }

        public decimal? FATSETUP { get; set; }

        public decimal? FATPROC { get; set; }

        public decimal? FATTRANSP { get; set; }

        public decimal? LTPMINIMO { get; set; }

        public decimal? LTPIDEAL { get; set; }

        public decimal? LTPMAXIMO { get; set; }

        public decimal? FATLOTESETUP { get; set; }

        public decimal? FATLOTEPROC { get; set; }

        public decimal? FATLOTETRANSP { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
