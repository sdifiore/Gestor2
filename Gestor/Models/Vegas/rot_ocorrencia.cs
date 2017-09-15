namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.rot_ocorrencia")]
    public partial class rot_ocorrencia
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDOCOR { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LANCAMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOCAL { get; set; }

        public Guid? UUIDOPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TPOCOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string TITULO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        public Guid? IDTURNO { get; set; }

        public DateTime? MOMOCORRENCIA { get; set; }

        [Column(TypeName = "mediumblob")]
        public byte[] FOTO_OCORR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FOTO_OCORR_TP { get; set; }

        public int? RESPDONO { get; set; }

        public int? RESPFOCO { get; set; }

        public int? PESSOAFOCO { get; set; }

        public Guid? EQUIPAMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string EQUIPDESC { get; set; }

        public Guid? LINKMASTER { get; set; }

        public Guid? LINKSUPERIOR { get; set; }

        public Guid? LINKOS { get; set; }

        public Guid? LINKATIV { get; set; }

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
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }
    }
}
