namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pronecprin")]
    public partial class pronecprin
    {
        [Key]
        public int IDNECPRIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime PER_PROD_INI { get; set; }

        [Column(TypeName = "date")]
        public DateTime PER_PROD_FIN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CALC_CUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string VERIF_CONSUMO { get; set; }

        public DateTime? MOMFECHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string CONTR_INTERNO { get; set; }

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
