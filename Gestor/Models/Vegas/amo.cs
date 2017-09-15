namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.amo")]
    public partial class amo
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDAMO { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDAMOSEQ { get; set; }

        public Guid? IDOS { get; set; }

        public Guid? IDATIVIDADE { get; set; }

        public Guid? IDPROV { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RESPONSA { get; set; }

        public int? RESP_DONO { get; set; }

        public DateTime? MOMINI { get; set; }

        public long? TEMPO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(16777215)]
        public string MEMO { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(9)]
        public string TIPOMO { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "char")]
        [StringLength(9)]
        public string TIPOSERV { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTOREQUIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string ORIGEMLOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        public DateTime? MOMFIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string DONOTAB { get; set; }

        public Guid? DONOID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FOCOTAB { get; set; }

        public int? FOCOID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODRECURSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

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
