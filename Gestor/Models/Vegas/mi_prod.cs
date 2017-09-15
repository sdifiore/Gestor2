namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.mi_prod")]
    public partial class mi_prod
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDPROD { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDPRODSEQ { get; set; }

        public Guid? UUIDCAB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(105)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DATAPEDIDO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(9)]
        public string TIPOMOV { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal QTD_PEDREC { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal QTD_APROVA { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal QTD_ATENDIDA { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal QTD_PERDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTPPERDA { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal PESO_BRUTO { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal PESO_LIQUI { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal BAIXAQTD { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSU { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "char")]
        [StringLength(10)]
        public string LOCAL_MOV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL_EMISS { get; set; }

        public int? RESP_DONO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO_DONO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB2 { get; set; }

        public Guid? ORIGEMID2 { get; set; }

        public decimal? CUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        public Guid? LINK { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string RASTREABTAB { get; set; }

        public Guid? RASTREABID { get; set; }

        public Guid? IDPLNPRODDT { get; set; }

        public Guid? IDPLANREC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSSINCCHK { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 15, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
