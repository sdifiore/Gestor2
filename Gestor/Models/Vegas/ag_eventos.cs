namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ag_eventos")]
    public partial class ag_eventos
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDEVENTO { get; set; }

        public Guid? EVENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOEVENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(90)]
        public string TITULO { get; set; }

        [StringLength(16777215)]
        public string DETALHES { get; set; }

        [Column(TypeName = "char")]
        [StringLength(90)]
        public string LOCAL { get; set; }

        public DateTime? MOM_INI { get; set; }

        public DateTime? MOM_FIN { get; set; }

        [StringLength(16777215)]
        public string PAUTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO { get; set; }

        public int? RESPONSA { get; set; }

        public int? AUTOR { get; set; }

        public Guid? IDOS { get; set; }

        public Guid? IDATIVIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONCLUITIPO { get; set; }

        public DateTime? CONCLUIMOM { get; set; }

        public int? CONCLUIRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(9)]
        public string TIPO_AVISO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIARIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
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

        [Key]
        [Column("_UCRC_", Order = 3, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
