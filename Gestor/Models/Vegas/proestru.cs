namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proestru")]
    public partial class proestru
    {
        [Key]
        public int IDPROESTRU { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string PRODGRADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string COMPONENTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string COMPGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(45)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        public decimal QTD { get; set; }

        public decimal QTDPAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BAIXA { get; set; }

        public int? ESTTARPAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        public decimal PERDAS { get; set; }

        public int POSICAO { get; set; }

        public decimal REFUGO { get; set; }

        [StringLength(16777215)]
        public string EXPRVARIACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FIN { get; set; }

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
