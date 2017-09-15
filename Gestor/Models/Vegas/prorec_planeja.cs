namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prorec_planeja")]
    public partial class prorec_planeja
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDPLANEJA { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UUIDTAREFA { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        public DateTime? MOMPLANINI { get; set; }

        public DateTime? MOMPLANFIN { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal QTD_PRODUZIR { get; set; }

        public DateTime? MOMREALINI { get; set; }

        public DateTime? MOMREALFIN { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal TMPTOTAL { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal TMPSETUP { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal TMPPROC { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal TMPTRANSP { get; set; }

        public decimal? TMPAJTOTAL { get; set; }

        public decimal? TMPAJSETUP { get; set; }

        public decimal? TMPAJPROC { get; set; }

        public decimal? TMPAJTRANSP { get; set; }

        public DateTime? MOMPLANLIB { get; set; }

        public DateTime? MOMREALLIB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string L_RECURSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string L_MOMPLAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string L_TMPAJUSTADO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTENTRPEDIDO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTALVOENTR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTPLANENTR { get; set; }

        public long? INDPRIORIDADE { get; set; }

        public long? INDFOLGA { get; set; }

        public long? INDTMPADIANTE { get; set; }

        public DateTime? MOMCALCENTR { get; set; }

        [StringLength(16777215)]
        public string CNSPREDECESSAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 9, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
