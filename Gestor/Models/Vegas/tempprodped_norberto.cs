namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.tempprodped_norberto")]
    public partial class tempprodped_norberto
    {
        [Key]
        public int IDPRODPED { get; set; }

        public Guid? UUIDPRODU { get; set; }

        public Guid? UUIDPEDIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        public decimal? VALOR { get; set; }

        public decimal? QTD_ORIG { get; set; }

        public decimal? QTD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREVISAO { get; set; }
    }
}
