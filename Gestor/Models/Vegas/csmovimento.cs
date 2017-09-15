namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.csmovimento")]
    public partial class csmovimento
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDMOV { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDMOV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string TIPOMOV { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime MOMMOV { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPESSOA { get; set; }

        public int? IDRESP { get; set; }

        public int? DOCUMENTO { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal QTDE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal VALORUN { get; set; }

        public decimal? DESCONTO { get; set; }

        public decimal? ACRESCIMO { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal BXQTDE { get; set; }

        public int? BXIDRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BXUSU { get; set; }

        public DateTime? BXMOM { get; set; }

        public Guid? LNKORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 9, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
