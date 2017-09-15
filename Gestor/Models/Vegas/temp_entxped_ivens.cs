namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_entxped_ivens")]
    public partial class temp_entxped_ivens
    {
        [Key]
        public int IDLAN { get; set; }

        public Guid? IDPEDIDO { get; set; }

        public Guid? IDPEDPRODDET { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string DESCRAGRUPA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRPROD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string STATUSPROD { get; set; }

        public decimal? QTD_ORIGEM { get; set; }

        public decimal? QTD_EFETIVA { get; set; }

        public decimal? QTD_ABERTO { get; set; }

        public decimal? QTD_APROVADA { get; set; }

        public decimal? QTD_REJEITADA { get; set; }

        public decimal? VLUN_ORIGEM { get; set; }

        public decimal? VALORREF_ORIGEM { get; set; }

        public decimal? VLUN_RECEBIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODGRADEORIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODLOCALORIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTEORIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONT_GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONT_LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONT_LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LIB_RECEB { get; set; }
    }
}
