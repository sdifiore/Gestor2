namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cobrconv")]
    public partial class cobrconv
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODCONV { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CONTA { get; set; }

        public long? SEQUENCIA { get; set; }

        public long? SEQMAX { get; set; }

        public int? SEQARQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string SEQ_EXTERNA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BANCO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string AGENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string AGENDIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CEDENCOD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string CEDENDIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string AUXILIAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CONVBANCO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DCC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string LAYOUT_OCORR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string CEDENTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string ESPECIEDOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string ACEITE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CARTEIRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string ESPECIE { get; set; }

        public decimal VALORTX { get; set; }

        public int? DIASVALIDA { get; set; }

        public int? DIASBAIXA { get; set; }

        [StringLength(16777215)]
        public string MENSAGEM1 { get; set; }

        [StringLength(16777215)]
        public string MENSAGEM2 { get; set; }

        [StringLength(16777215)]
        public string MSGBANCO { get; set; }

        [Column(TypeName = "mediumblob")]
        public byte[] IMAGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string IMAGEM_TPI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string VISUAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PADRAO { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string IMPEXPPROC { get; set; }

        [StringLength(16777215)]
        public string IMPEXPVARS { get; set; }

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
