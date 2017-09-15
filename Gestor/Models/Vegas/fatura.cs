namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.fatura")]
    public partial class fatura
    {
        [Key]
        public int IDFATURA { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOFAT { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string SERIE { get; set; }

        public int? NUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NFETIPOEMISSAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string NFENUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NFEPROTOCOLO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string NFESTATUS { get; set; }

        public DateTime? NFESTATMOM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(15)]
        public string OPERACAO { get; set; }

        public int? VENDEDOR { get; set; }

        public int? VENDEDORPED { get; set; }

        public int? IDCONTRATO { get; set; }

        public int PESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string RAZ_SOCIAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CNPJ_CPF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string IE_RG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string INSC_MUN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOGRADOURO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string ENDERECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ENDNUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(25)]
        public string BAIRRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string ESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string CIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string PAIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CEP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FONE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string EMAIL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ENTR_LOGRADOURO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string ENTR_ENDERECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ENTR_ENDNUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ENTR_COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(25)]
        public string ENTR_BAIRRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string ENTR_CIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string ENTR_ESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string ENTR_CEP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string ENTR_PAIS { get; set; }

        public int? TRANSPORTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string TRSP_RAZ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string TRSPCNPJ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string TRSP_RNTC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string TRSPIE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string TRSPENDER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string TRSPCIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string TRSPESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string TRSPEMAIL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string TRSPPLACA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string TRSPUFPLAC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string TIPOFRETE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string TRMODAFRETE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string VIATRANSP { get; set; }

        public decimal TRSPQTD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string TRSPESPECI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string TRSPMARCA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string TRSPNUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string TRSPPEBRUT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string TRSPPELIQU { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal ACRESCIMO { get; set; }

        public decimal VALORPROD { get; set; }

        public decimal VALORSERV { get; set; }

        public decimal BASEICMS { get; set; }

        public decimal VALICMS { get; set; }

        public decimal BASEICMSUB { get; set; }

        public decimal VALICMSSUB { get; set; }

        public decimal VALORFRETE { get; set; }

        public decimal VALORSEG { get; set; }

        public decimal OUTRASDESP { get; set; }

        public decimal VALORIPI { get; set; }

        public decimal VALORTOT { get; set; }

        public decimal VALCONTABIL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string MODELOECF { get; set; }

        public int? NUMEROECF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CUPOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOMSG { get; set; }

        [StringLength(16777215)]
        public string MENSAGEM { get; set; }

        public int? DESMEMBRA { get; set; }

        public DateTime? EMIS_MOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string EMIS_USU { get; set; }

        public DateTime? DATASAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CALCULADO { get; set; }

        public DateTime? CANCELAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CANCELAUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CANCELAMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        public int? LINK { get; set; }

        public int? IDNFE { get; set; }

        public DateTime? FECHAMENTO { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string EMAIL_STATUS { get; set; }

        public DateTime? EMAIL_ENVIO { get; set; }

        public int? EMAIL_TENTATIVA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
