namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_pedmonitsta_tatiane")]
    public partial class temp_pedmonitsta_tatiane
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LANCAMENTO { get; set; }

        public Guid? IDPEDPRODU { get; set; }

        public Guid? IDDETPRODU { get; set; }

        public Guid? IDENTPRODU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public decimal? PROD_QTD { get; set; }

        public decimal? PROD_VLUNIT { get; set; }

        public decimal? PROD_VLTOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ULTSTADESCR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ULTSTADATA { get; set; }

        public Guid? IDPEDIDO { get; set; }

        public decimal? IDPEDSEQ { get; set; }

        public Guid? IDENTRADA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string FORNECEDOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string SUPERIOR { get; set; }

        [Column("__COR")]
        public decimal? C__COR { get; set; }
    }
}
