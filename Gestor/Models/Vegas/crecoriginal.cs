namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.crecoriginal")]
    public partial class crecoriginal
    {
        [Key]
        public int IDORIGINAL { get; set; }

        public int IDNEGOCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENCIMENTO { get; set; }

        public decimal VALOR_ORIG { get; set; }

        public decimal ACRESCIMO { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal JUROS { get; set; }

        public decimal VALOR_FIN { get; set; }

        public int? ORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string RENEGOCIADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
