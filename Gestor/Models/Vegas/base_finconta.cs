namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_finconta")]
    public partial class base_finconta
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODCONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BANCO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string AGENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string AGENDIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string MOEDA { get; set; }

        public decimal LIMITE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENCIMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string NUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string NUMDIG { get; set; }

        public int? NUMATUAL { get; set; }

        public int? NUMFIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CONTATO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FONE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PADRAOEMPR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string VISUAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONCILIA { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string PAGBANCONV { get; set; }

        public int? PAGBANSEQARQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string PAGBANPROC { get; set; }

        [StringLength(16777215)]
        public string PAGBANVARS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ST2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTCONCILIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string USUCONCILIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSPADRAO { get; set; }

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
