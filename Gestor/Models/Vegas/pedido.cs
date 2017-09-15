namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pedido")]
    public partial class pedido
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPEDIDO { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDPEDSEQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NUMPEDFORN { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DOCUMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string REFERENCIA { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORNECEDOR { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(9)]
        public string TIPOPED { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ORIGDPTO { get; set; }

        public int? ORIGRESP { get; set; }

        public int? IDCONTRATO { get; set; }

        public Guid? REPRESEN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FORMAPG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOTRANSP { get; set; }

        public int? TRANSPORTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string TRSPPLACA { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal TRSPQTD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string TRSPESPECI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string TRSPPEBRUT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string TRSPPELIQU { get; set; }

        public int? SOLICITA { get; set; }

        public int? IDCOTACAO { get; set; }

        public int? RESPAPROVA { get; set; }

        public int? RESPCOMPRA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTCOLOCACA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTPREVFAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTPREVENTR { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal DESCONTO { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ACRESCIMO { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal IPI { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal ICMSSUB { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal SEGURO { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal FRETE { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal OUTROS { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal VALORTOT { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal VALORTOTREF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string REF_INDIC { get; set; }

        [StringLength(16777215)]
        public string NEGOCIACAO { get; set; }

        [StringLength(16777215)]
        public string RECEBIMENT { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? FECHAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string FECHAUSU { get; set; }

        public DateTime? CONCLMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CONCLUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FISC_CALCULADO { get; set; }

        [StringLength(16777215)]
        public string FISC_INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        public int? IDCOMREC { get; set; }

        public int? IDHISTREC { get; set; }

        [Key]
        [Column("_UCRC_", Order = 18, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
