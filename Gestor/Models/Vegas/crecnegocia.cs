namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.crecnegocia")]
    public partial class crecnegocia
    {
        [Key]
        public int IDNEGOCIA { get; set; }

        public int PESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CNPJ_CPF { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTFATURA { get; set; }

        public Guid? PEDIDO { get; set; }

        public decimal TOTPED { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOTE { get; set; }

        public int? VENDEDOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TPDUPLIC { get; set; }

        public int? PARCELA { get; set; }

        public int? PARCTOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string BANCO { get; set; }

        public decimal CREDITO { get; set; }

        public decimal JUROS { get; set; }

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
