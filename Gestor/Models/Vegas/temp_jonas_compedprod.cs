namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_jonas_compedprod")]
    public partial class temp_jonas_compedprod
    {
        [Key]
        public int IDLAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CODUNIVERS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string REFERENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        public decimal? QTD { get; set; }

        public decimal? VALOR { get; set; }
    }
}
