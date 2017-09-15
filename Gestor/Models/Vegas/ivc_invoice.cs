namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ivc_invoice")]
    public partial class ivc_invoice
    {
        [Key]
        [Column(Order = 0)]
        public int IDINVOICE { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UIDINVOICE { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(9)]
        public string TIPOINVOICE { get; set; }

        public int? NUMINVOICE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string REFINVOICE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        public int? IMP_PESSOA { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(60)]
        public string IMP_NOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string IMP_RESPONSA { get; set; }

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
        [StringLength(9)]
        public string CODPGTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PGTOMOEDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TPFRETE { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DIMENSOES { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CUBAGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string MEDIDADPADRAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PESOLIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PESOBRUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string VALIDADE { get; set; }

        public decimal? SUBTOTAL { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal DESCONTO { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal FRETE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal SEGURO { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal DESPESAS { get; set; }

        public DateTime? MOMFECHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

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
