namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_prodproduzido")]
    public partial class temp_prodproduzido
    {
        [Key]
        public int IDLANCA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPROD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MOVLOTEINTEGRAL { get; set; }

        public decimal QTDESTOQUE { get; set; }

        public decimal PESO_BRUTO { get; set; }

        public decimal PESO_LIQUI { get; set; }

        public int? LINK { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }
    }
}
