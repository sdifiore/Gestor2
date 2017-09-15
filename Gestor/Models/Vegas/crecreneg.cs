namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.crecreneg")]
    public partial class crecreneg
    {
        [Key]
        public int IDRENEG { get; set; }

        public DateTime? MOMRENE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string USURENE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string OBS { get; set; }

        public decimal VALORTOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string ORIGTAB { get; set; }

        public Guid? ORIGID { get; set; }

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
