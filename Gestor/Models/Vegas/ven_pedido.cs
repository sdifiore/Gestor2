namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_pedido")]
    public partial class ven_pedido
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDPEDIDO { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDPEDIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(25)]
        public string MATRICULA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NUMPEDCLI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PESSOA { get; set; }

        public int? IDCONTRATO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(9)]
        public string TIPOPED { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime DATA { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DEPTO { get; set; }

        public int? CLI_COMPLEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOTE { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "char")]
        [StringLength(9)]
        public string FORMAPG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPODOC { get; set; }

        public int? VENDEDOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODREGRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string MARKETING { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string REFER { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal PERC_ACRESC { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal DESCONTO1 { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal DESCONTO2 { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal DESCONTO3 { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal DESCONTO4 { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal DESCONTOVAL { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal FRETE { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal VALORSEG { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal OUTRASDESP { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal VALORIPI { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal VALICMSSUB { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal VALORTOT { get; set; }

        [StringLength(16777215)]
        public string DESC_ACRESC_MC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VALIDADE { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        [StringLength(16777215)]
        public string INFO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOMSG { get; set; }

        [StringLength(16777215)]
        public string MENSAGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CAR_TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CAR_NUM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string CAR_DIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CAR_VALID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CAR_AUT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string CAR_HASH { get; set; }

        public DateTime? FECHAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string FECHAUSU { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PREVISAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EXPEDFORMA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EXPEDSTATUS { get; set; }

        public DateTime? EXPEDMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string EXPEDUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string EXPEDTAB { get; set; }

        public int? EXPEDID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string EMAPROVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FATURADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string COBRADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FISC_CALCULADO { get; set; }

        [StringLength(16777215)]
        public string FISC_INFOS { get; set; }

        public int? TRANSPORTADORA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONTA_FRETE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(7)]
        public string PLACA { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal QUANTIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string ESPECIE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string MARCA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PESOBRUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PESOLIQUIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string UFPLACA { get; set; }

        public DateTime? AVALIA_REPRMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string AVALIA_REPRUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string AVALIA_REPRSTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        public Guid? ORCAMENTO { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public int? IDHISTREC { get; set; }

        public int? IDPEDREC { get; set; }

        [Key]
        [Column("_UCRC_", Order = 22, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
