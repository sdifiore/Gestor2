namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_atv_tpfato")]
    public partial class os_atv_tpfato
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTPATVFATO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DESCRBANDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGESPEC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODESPEC { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string PROCFILTRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVADO { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string SELECTEXPR { get; set; }

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
        public string CNSPADRAO { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string CNSAJUDA { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
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
