namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ag_agenda_m")]
    public partial class ag_agenda_m
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDAGENDA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RESPONSA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(90)]
        public string TITULO { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        public Guid? EVENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(90)]
        public string LOCAL { get; set; }

        public DateTime? MOM_INI { get; set; }

        public DateTime? MOM_FIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO_AVISO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIARIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PRIVADO { get; set; }

        public Guid? IDOS { get; set; }

        public Guid? IDATIVIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONCLUI_TIPO { get; set; }

        public DateTime? CONCLUI_MOM { get; set; }

        public int? CONCLUI_RESP { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LINHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEM_MODULO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEM_TABELA { get; set; }

        public Guid? ORIGEM_ID { get; set; }

        public Guid? LINK_PAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PROCESSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string SINC_EXT_ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

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
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSSINCCHK { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
