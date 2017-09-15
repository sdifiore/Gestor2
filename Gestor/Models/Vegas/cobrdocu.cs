namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cobrdocu")]
    public partial class cobrdocu
    {
        [Key]
        public int IDDOCUM { get; set; }

        public int IDCOBRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENCORIG { get; set; }

        public decimal VALORORIG { get; set; }

        public decimal JUROS { get; set; }

        public decimal MULTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string ORIGEMLOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

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
