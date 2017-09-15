namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ger_tabreg_pk")]
    public partial class ger_tabreg_pk
    {
        [Key]
        public int IDTRPK { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string CODTABELA { get; set; }

        [StringLength(16777215)]
        public string PK_VALORES { get; set; }

        [StringLength(16777215)]
        public string EXPRESSAO { get; set; }

        [StringLength(16777215)]
        public string GRPS { get; set; }

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
