namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pessoa")]
    public partial class pessoa
    {
        [Key]
        public int IDPESSOA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string COBRA_CATEG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string MATRICULA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string FIS_JUR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CLI_FOR { get; set; }

        public int? RESPONSAVEL { get; set; }

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
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SEGMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string EMAIL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string SITE { get; set; }

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
        [StringLength(12)]
        public string VOIP { get; set; }

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
        [StringLength(30)]
        public string BAIRRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
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

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string REGIAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPEMPICMS_CLI { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPEMPICMS_FOR { get; set; }

        public decimal EMPICMS_CREDSN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPEMPIPI_FOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPEMPPIS_FOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPEMPISS_FOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string INSC_MUN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string INSC_PROD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string ZFINSCR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ZFVALIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNAE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string RNTC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CRT { get; set; }

        public decimal LATITUDE { get; set; }

        public decimal LONGITUDE { get; set; }

        public int ALTITUDE { get; set; }

        public int? LINK { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CONTATO { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string CNSHASHMD5 { get; set; }

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
