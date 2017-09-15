namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_prodprev")]
    public partial class os_prodprev
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPRODPREV { get; set; }

        public Guid? OS { get; set; }

        public Guid? ATIVIDADE { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LANCAMENTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        public int QTD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        public decimal VALORBASE { get; set; }

        public decimal? VALORTOTAL { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        public Guid? ORCAMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }
    }
}
