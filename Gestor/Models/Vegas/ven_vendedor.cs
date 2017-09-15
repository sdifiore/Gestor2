namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_vendedor")]
    public partial class ven_vendedor
    {
        [Key]
        public int IDVENDEDOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string NOME { get; set; }

        public int? RESPONSAVEL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string FIS_JUR { get; set; }

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
        [StringLength(6)]
        public string LOGRADOURO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ENDERECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string NUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
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

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string DDI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(11)]
        public string FONE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(11)]
        public string FAX { get; set; }

        [Column(TypeName = "char")]
        [StringLength(11)]
        public string CELULAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CONTATO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string RESTR_GRUPO_PESSOA { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }
    }
}
