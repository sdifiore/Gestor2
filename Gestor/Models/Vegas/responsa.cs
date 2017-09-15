namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.responsa")]
    public partial class responsa
    {
        [Key]
        public int IDRESP { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string NOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string APELIDO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTNASC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SEXO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FUNCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(11)]
        public string RG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(11)]
        public string CPF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string REGIMECONTR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string REGPROF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NCARTTRAB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NPIS { get; set; }

        public decimal SALARIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTO { get; set; }

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
        [StringLength(10)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string BAIRRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string CIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string ESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PAIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CPOSTAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string REGIAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string DDI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(12)]
        public string FONE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(12)]
        public string FAX { get; set; }

        [Column(TypeName = "char")]
        [StringLength(12)]
        public string CELULAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string EMAIL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTCONTRATO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTRESCISAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string RESP_USUAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string RESP_SENHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string USU_APLIC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string SINC_EXT_ATIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string SINC_EXT_SENHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string SINC_EXT_ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CNH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CNHVALIDAD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string CNHCATEG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MOTORISTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOMO { get; set; }

        public int? LINK { get; set; }

        public int? IDPESSOA { get; set; }

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
