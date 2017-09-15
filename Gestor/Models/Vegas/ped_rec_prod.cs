namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ped_rec_prod")]
    public partial class ped_rec_prod
    {
        [Key]
        public int IDPRODU { get; set; }

        public int IDCOMREC { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        public decimal QTD { get; set; }

        public decimal VALOR { get; set; }

        public decimal ACRESCIMO { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal DESC_VALOR { get; set; }

        public decimal VALORTOTAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string GRUPOPRECO { get; set; }

        public decimal RATEIO { get; set; }

        public decimal GERRATEIO { get; set; }

        public decimal GEROUTROS { get; set; }

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

        public decimal VALORRAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIM { get; set; }
    }
}
