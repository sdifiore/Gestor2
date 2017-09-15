namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_cockpitmater_qtd_marcelo")]
    public partial class temp_cockpitmater_qtd_marcelo
    {
        [Key]
        public int IDLAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        public decimal? QTD { get; set; }

        public decimal? PRECO { get; set; }

        public decimal? CUSTOFINAL_UN { get; set; }
    }
}
