namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.rot_providencia")]
    public partial class rot_providencia
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPROV { get; set; }

        public Guid? IDOCOR { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDPROVSEQ { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string REFERENCIA { get; set; }

        [StringLength(16777215)]
        public string MENSAGEM { get; set; }

        [StringLength(16777215)]
        public string RESPOSTA { get; set; }

        [StringLength(16777215)]
        public string JUSTIFICA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTPREVRET { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODURGENCIA { get; set; }

        public decimal? TEMPOPREVISTO { get; set; }

        public int? ORDEMFILA { get; set; }

        public int? RESPREMETENTE { get; set; }

        public int? RESPDESTINO { get; set; }

        public int? PESSOADESTINO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CLASSFECHA { get; set; }

        public DateTime? MOMRECEB { get; set; }

        public DateTime? MOMRETORNO { get; set; }

        public DateTime? MOMFECHA { get; set; }

        [Column(TypeName = "mediumblob")]
        public byte[] IMAGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FOTO_PROV_TPI { get; set; }

        public Guid? LINKMASTER { get; set; }

        public Guid? LINKSUPERIOR { get; set; }

        public Guid? LINKATIV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        public decimal? INI_PREVTEMPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INI_PREVDATA { get; set; }

        public DateTime? AUDIT_FECHAMENTO { get; set; }

        public int? AUDIT_RESPONSA { get; set; }

        [StringLength(16777215)]
        public string AUDIT_OBSERVACOES { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }
    }
}
