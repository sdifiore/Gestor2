namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_prodatendido")]
    public partial class temp_prodatendido
    {
        [Key]
        public int IDLANCA { get; set; }

        public Guid? LINKESTOQUE { get; set; }

        public Guid? LINKPRODPED { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MOVLOTEINTEGRAL { get; set; }

        public decimal QTD { get; set; }

        public decimal VALORUNIT { get; set; }

        public decimal PESO_BRUTO { get; set; }

        public decimal PESO_LIQUI { get; set; }

        public Guid? NUMPEDIDO { get; set; }

        public int? CLIENTEPEDIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string BLOQUEADO { get; set; }
    }
}
