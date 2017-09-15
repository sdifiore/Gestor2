namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.procargatrib")]
    public partial class procargatrib
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDCARGATRIB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODIGO { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(16777215)]
        public string DESCRICAO { get; set; }

        public int? EXTIPI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string FONTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        public decimal? ALIQ_NAC { get; set; }

        public decimal? ALIQ_IMP { get; set; }

        public decimal? ALIQ_EST { get; set; }

        public decimal? ALIQ_MUN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CHAVE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string VERSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VIGEN_INI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VIGEN_FIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 3, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
