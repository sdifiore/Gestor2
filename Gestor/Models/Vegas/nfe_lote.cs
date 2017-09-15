namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.nfe_lote")]
    public partial class nfe_lote
    {
        [Key]
        public int IDLOTE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOLOTE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        public DateTime? EMISMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string EMISUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string EMISARQ { get; set; }

        public DateTime? RETMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string RETUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string RETARQ { get; set; }

        public DateTime? CONC_MOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONC_OK { get; set; }

        public int? LINK { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        [StringLength(1073741823)]
        public string INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }
    }
}
