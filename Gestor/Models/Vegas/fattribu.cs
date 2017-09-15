namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.fattribu")]
    public partial class fattribu
    {
        [Key]
        public int IDTRIBU { get; set; }

        public int IDFATURA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TRIBUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CODIGO { get; set; }

        public decimal ALIQUOTA { get; set; }

        public decimal BASE { get; set; }

        public decimal VALOR { get; set; }

        public decimal REDUCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string COD_TRIB { get; set; }

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
