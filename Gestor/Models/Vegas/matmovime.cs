namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.matmovime")]
    public partial class matmovime
    {
        [Key]
        public int IDMOVIME { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOMOVIM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        public int? DONORESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DONODPTO { get; set; }

        [StringLength(16777215)]
        public string OBSERVA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string MOVLOCAL { get; set; }

        public int? MOVRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FECHATIPO { get; set; }

        public DateTime? FECHAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string FECHAUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string ORIGEMLOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        public int? LINKPAI { get; set; }

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

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
