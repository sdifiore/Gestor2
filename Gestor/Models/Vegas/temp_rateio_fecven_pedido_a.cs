namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_rateio_fecven_pedido_a")]
    public partial class temp_rateio_fecven_pedido_a
    {
        public int ID { get; set; }

        public Guid? IDPAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PRODUTOINT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string ORIGEMCLASS { get; set; }

        public Guid? UUIDRATEIO { get; set; }

        public Guid? UUIDPEDIDO { get; set; }

        public Guid? UUIDPRODU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FOCO { get; set; }

        public decimal? VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public decimal? IDRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        public DateTime? CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
