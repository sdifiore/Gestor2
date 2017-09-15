namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cobra_m")]
    public partial class cobra_m
    {
        [Key]
        public int IDCOBRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CONVENIO { get; set; }

        public long? SEQUENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string SEQ_EXTERNA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string SACADOTAB { get; set; }

        public int SACADOID { get; set; }

        public Guid? SACADOUUID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string SACADOEMAIL { get; set; }

        [StringLength(16777215)]
        public string SACADOEMAILCC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DOCUMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        public int? PARCELA { get; set; }

        public int? PARCTOT { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime VENCIMENTO { get; set; }

        public decimal VALOR { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal OUTROS { get; set; }

        public decimal JUROS { get; set; }

        public decimal MULTA { get; set; }

        public decimal VALORTOT { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BAIXADATA { get; set; }

        public decimal BAIXAVALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string BAIXAUSUAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BAIXATIPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BAIXAMAX { get; set; }

        public DateTime? EMISSMOM { get; set; }

        public DateTime? EXPORTAMOM { get; set; }

        public DateTime? ENVIOMOM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VALIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string DC_BANCO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string DC_AGENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string DC_AGENDIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DC_CONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string DC_CONTDIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DC_TITULAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string DC_CNPJ_CPF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public decimal JUROSCALC { get; set; }

        public decimal COMISSAO { get; set; }

        public decimal QTD { get; set; }

        public decimal VALORUNIT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string REFERENCIA { get; set; }

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
        public string CEP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOGRADOURO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ENDERECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string NUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string BAIRRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string PAIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CPOSTAL { get; set; }

        public int? IDFECHA { get; set; }

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
