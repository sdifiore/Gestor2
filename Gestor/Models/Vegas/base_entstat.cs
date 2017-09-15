namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_entstat")]
    public partial class base_entstat
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODSTATUS { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DESCRHIST { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(120)]
        public string CNSTREE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string REALIZA_FECHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string REALIZA_EXPFINAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string RASTREABILIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string CNSGRPIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string CNSGRPOUT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string TAB_EDIT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string CNSPROXSTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSOBRIGAMOTIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NCONSIDFLUXO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string STA_MONIT { get; set; }

        public int? STA_MONITDIAS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string GRUPO_MONIT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSBLOQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSPADRAO { get; set; }

        public long? CNSSTATCOR { get; set; }

        [StringLength(16777215)]
        public string CNSAJUDA { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

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
