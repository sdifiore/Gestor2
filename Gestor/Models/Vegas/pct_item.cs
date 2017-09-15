namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pct_item")]
    public partial class pct_item
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDITEM { get; set; }

        public Guid? UIDPACOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOITEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DOCUMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal QUANTIDADE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal PESO { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string TAMANHO { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 5, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
