namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.matmovprod")]
    public partial class matmovprod
    {
        [Key]
        public int IDPRODU { get; set; }

        public int IDMOVIME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string LOTE { get; set; }

        public decimal QTDPEDIDA { get; set; }

        public decimal QTDREAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        public decimal PESO_BRUTO { get; set; }

        public decimal PESO_LIQUI { get; set; }

        public decimal BAIXAQTD { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CODBARRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CODUNIVERS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNID { get; set; }

        public decimal FATOR { get; set; }

        public decimal QTDEST { get; set; }

        public decimal CUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string ORIGEMLOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

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
