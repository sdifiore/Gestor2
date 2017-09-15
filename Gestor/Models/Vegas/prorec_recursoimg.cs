namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prorec_recursoimg")]
    public partial class prorec_recursoimg
    {
        [Key]
        public int IDIMAGEM { get; set; }

        public Guid UUIDRECURSO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "mediumblob")]
        public byte[] IMAGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string IMAGEM_TPI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        [Column("__COR")]
        public long? C__COR { get; set; }

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
