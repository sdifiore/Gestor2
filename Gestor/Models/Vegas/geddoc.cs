namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.geddoc")]
    public partial class geddoc
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDDOC { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LANDOC { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(20)]
        public string TIPODOC { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(100)]
        public string NOMEARQ { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(100)]
        public string TITULO { get; set; }

        [StringLength(16777215)]
        public string RESUMO { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "date")]
        public DateTime DATREC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string REFDOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string REFUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DONDEP { get; set; }

        public int? DONRESP { get; set; }

        public Guid? PAI { get; set; }

        public Guid? MASTER { get; set; }

        [StringLength(16777215)]
        public string VARIAVEIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 7, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
