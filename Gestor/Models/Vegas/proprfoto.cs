namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proprfoto")]
    public partial class proprfoto
    {
        [Key]
        public int IDITEM { get; set; }

        public int? IDFOTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CODUNIVERS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string LOCALIZA { get; set; }

        public decimal? QTD_CONTADA { get; set; }

        public decimal QTD_APURADA { get; set; }

        public decimal CUSTO_GER { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        public decimal? BAIXAQTD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string CNSCANMOT { get; set; }
    }
}
