namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_recorrencia")]
    public partial class ven_recorrencia
    {
        [Key]
        public int IDPEDREC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(3)]
        public string EXECUCAO { get; set; }

        public int DIAVENC { get; set; }

        [Column(TypeName = "date")]
        public DateTime INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOPED { get; set; }

        public int PESSOA { get; set; }

        public int? IDCONTRATO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DEPTO { get; set; }

        public int? CLI_COMPLEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
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
        [StringLength(9)]
        public string STATUSPED { get; set; }

        public decimal VALOR { get; set; }

        public decimal PERC_ACRESC { get; set; }

        public decimal DESCONTO1 { get; set; }

        public decimal DESCONTO2 { get; set; }

        public decimal DESCONTO3 { get; set; }

        public decimal DESCONTO4 { get; set; }

        public decimal DESCONTOVAL { get; set; }

        public decimal FRETE { get; set; }

        public decimal VALORSEG { get; set; }

        public decimal OUTRASDESP { get; set; }

        public decimal VALORTOT { get; set; }

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
        public string EXPEDFORMA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EXPEDSTATUS { get; set; }

        public int? TRANSPORTADORA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONTA_FRETE { get; set; }

        public decimal QUANTIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string ESPECIE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string MARCA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PESOBRUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PESOLIQUIDO { get; set; }

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
