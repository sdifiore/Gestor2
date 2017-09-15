namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_prodped")]
    public partial class temp_prodped
    {
        [Key]
        public int IDLANCA { get; set; }

        public int PRODPRODUZIDO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

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

        public decimal VALORUNIT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREVISAO { get; set; }

        public decimal QTDPEDIDA { get; set; }

        public decimal QTDATENPED { get; set; }

        public Guid? PEDIDO { get; set; }

        public Guid? PEDCLI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NUMITEMPEDCLI { get; set; }

        public Guid? PRODPEDVEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAPED { get; set; }

        public int? CLIENTE { get; set; }
    }
}
