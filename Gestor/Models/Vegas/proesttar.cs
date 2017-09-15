namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proesttar")]
    public partial class proesttar
    {
        [Key]
        public int IDETRTAREFA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string PRODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTAREFA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(45)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        public int POSICAO { get; set; }

        public decimal SETUP { get; set; }

        public decimal TEMPO { get; set; }

        public decimal QTDPAI { get; set; }

        [StringLength(16777215)]
        public string EXPRVARIACAO { get; set; }

        public Guid? ORIGEMID { get; set; }

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
