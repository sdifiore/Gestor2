namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.saiextra")]
    public partial class saiextra
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDEXTRA { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDSAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOEXTRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AUXILIAR { get; set; }

        public int? PESSOA { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal QTD { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal VALORTOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 6, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
