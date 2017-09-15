namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.fxcprodu")]
    public partial class fxcprodu
    {
        [Key]
        public int IDPRODU { get; set; }

        public int IDCARTEIRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(150)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NAOFATURAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CFOP { get; set; }

        public decimal QTD { get; set; }

        public decimal VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIM { get; set; }

        public decimal? VALORRAT { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
