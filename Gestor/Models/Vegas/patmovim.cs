namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.patmovim")]
    public partial class patmovim
    {
        [Key]
        public int IDPATMOV { get; set; }

        public Guid? EVENTO { get; set; }

        public Guid IDPATRI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? RESPORIGEM { get; set; }

        public int? RESPDEST { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOCALORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOCALDEST { get; set; }

        public DateTime? DTSAIPREV { get; set; }

        public DateTime? DTSAIREAL { get; set; }

        public DateTime? DTRETPREV { get; set; }

        public DateTime? DTRETREAL { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
