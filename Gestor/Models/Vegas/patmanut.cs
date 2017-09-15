namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.patmanut")]
    public partial class patmanut
    {
        [Key]
        public int IDPATMAN { get; set; }

        public Guid IDPATRI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOMANUT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(25)]
        public string DESCRICAO { get; set; }

        public int? IDRESP { get; set; }

        public int? IDPESSOA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_PREVINI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_PREVFIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FIN { get; set; }

        public decimal VALOR { get; set; }

        public decimal DOLAR { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

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
