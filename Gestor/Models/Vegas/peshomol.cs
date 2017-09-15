namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.peshomol")]
    public partial class peshomol
    {
        [Key]
        public int IDHOMOL { get; set; }

        public int IDPESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TPHOMOL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FAMILIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string MARCA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(35)]
        public string DESCRICAO { get; set; }

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
