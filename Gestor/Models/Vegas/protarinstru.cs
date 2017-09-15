namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.protarinstru")]
    public partial class protarinstru
    {
        [Key]
        public int IDINSTRU { get; set; }

        public int IDETRTAREFA { get; set; }

        public int? IDENGVERSAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string TITULO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "mediumblob")]
        public byte[] IMAGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string IMAGEM_TPI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string LEGENDA { get; set; }

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
