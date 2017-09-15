namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_opconsu_ivens_f")]
    public partial class temp_opconsu_ivens_f
    {
        [Key]
        public int IDLAN { get; set; }

        public Guid? UUIDPROD { get; set; }

        public Guid? IDOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODLOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BX_CONSUMO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BX_PROCESSO { get; set; }

        public decimal? QTDJAAPONT { get; set; }

        public decimal? QTDJAPERDA { get; set; }

        public decimal? QTDAPONT { get; set; }

        public decimal? QTDPERDA { get; set; }

        public decimal? PESO_BRUTO { get; set; }

        public decimal? PESO_LIQUI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTPPERDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODGRADEORIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODLOCALORIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTEORIG { get; set; }
    }
}
