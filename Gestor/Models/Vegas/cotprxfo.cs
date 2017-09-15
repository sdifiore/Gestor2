namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cotprxfo")]
    public partial class cotprxfo
    {
        [Key]
        public int IDPROXFOR { get; set; }

        public int IDCOTACAO { get; set; }

        public int IDPRODU { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        public int IDFORNE { get; set; }

        public int FORNECEDOR { get; set; }

        public decimal VALORREF { get; set; }

        public decimal VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FORMA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTVALID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTPREVENTR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string REFERENCIA { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string APROVA { get; set; }

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
