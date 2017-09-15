namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proxfor")]
    public partial class proxfor
    {
        [Key]
        public int IDPROXFOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        public int IDPESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string REFERENCIA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UE_DATA { get; set; }

        public decimal UE_VALOR { get; set; }

        public decimal UE_QTD { get; set; }

        public decimal UE_CUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string UE_ORIG { get; set; }

        public Guid? UE_ID { get; set; }

        public decimal PRECO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ALTERA { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal ADICFINAN { get; set; }

        public decimal CUSTOFINAL_ENTR { get; set; }

        public decimal CUSTOFINAL_UN { get; set; }

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
