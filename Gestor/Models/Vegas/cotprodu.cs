namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cotprodu")]
    public partial class cotprodu
    {
        [Key]
        public int IDPRODU { get; set; }

        public int IDCOTACAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        public decimal QTD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        public decimal VALORREF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CODUNIVERS { get; set; }

        [StringLength(16777215)]
        public string DETALHE { get; set; }

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
