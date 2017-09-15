namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_entxped_edmea_f")]
    public partial class temp_entxped_edmea_f
    {
        [Key]
        public int IDLAN { get; set; }

        public Guid? IDPEDIDO { get; set; }

        public Guid? IDPEDPRODDET { get; set; }

        public Guid? IDENTANT { get; set; }

        public Guid? IDENTRADA { get; set; }

        public Guid? IDENTPROD { get; set; }

        public Guid? REJEITADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string TIPORECEB { get; set; }

        public decimal? QTD_ORIGEM { get; set; }

        public decimal? QTD_EFETIVA { get; set; }

        public decimal? QTD_ABERTO { get; set; }

        public decimal? QTD_APROVADA { get; set; }

        public decimal? QTD_REJEITADA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODLOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        public decimal? VLUN_ORIGEM { get; set; }

        public decimal? VALORREF_ORIGEM { get; set; }

        public decimal? VLUN_RECEBIDO { get; set; }

        public decimal? DESC_VALOR_RECEB { get; set; }

        public decimal? DESC_PERC_RECEB { get; set; }

        public decimal? VLTOTAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODGRADEORIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODLOCALORIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTEORIG { get; set; }
    }
}
