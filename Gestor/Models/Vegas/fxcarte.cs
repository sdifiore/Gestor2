namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.fxcarte")]
    public partial class fxcarte
    {
        [Key]
        public int IDCARTEIRA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        public int PESSOA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string GRUPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPODOC { get; set; }

        public int? DIAVENC { get; set; }

        [Column(TypeName = "date")]
        public DateTime INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONVCOBR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FATURAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CFOP { get; set; }

        public decimal ISSFONTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string ISSPLANO { get; set; }

        [StringLength(16777215)]
        public string ISSMENSAGEM { get; set; }

        public DateTime? ULTLANCA { get; set; }

        public decimal ULTVALOR { get; set; }

        public int? ULTLANCREC { get; set; }

        public int? ULTLANCCOB { get; set; }

        public int? ULTLANCFAT { get; set; }

        [StringLength(16777215)]
        public string CONTRATO { get; set; }

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
        [StringLength(1)]
        public string ST2 { get; set; }

        public decimal VALORRAT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string COBRA_CATEG { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
