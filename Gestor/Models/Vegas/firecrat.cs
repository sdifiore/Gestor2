namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.firecrat")]
    public partial class firecrat
    {
        [Key]
        public int IDRATEIO { get; set; }

        public int IDPRODU { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FOCO { get; set; }

        public decimal VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        public int? IDRESP { get; set; }

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
