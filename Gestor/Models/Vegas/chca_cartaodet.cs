namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.chca_cartaodet")]
    public partial class chca_cartaodet
    {
        [Key]
        public int IDCARTAODET { get; set; }

        public int IDCARTAOARQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(12)]
        public string COMPROVANTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AUTENTICACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTVENDA { get; set; }

        public int? PARCELA { get; set; }

        public int? PARCTOT { get; set; }

        public decimal VALOR { get; set; }

        public decimal VALORLIQ { get; set; }

        public int? OCORRENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string OCOR_DESC { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string BAIXAUSU { get; set; }

        public Guid? IDORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string TABORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LINK { get; set; }

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
