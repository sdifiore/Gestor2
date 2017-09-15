namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_rectpfato")]
    public partial class os_rectpfato
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DESCRBANDA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVADO { get; set; }

        [StringLength(16777215)]
        public string SELECTEXPRQTD { get; set; }

        [StringLength(16777215)]
        public string SELECTEXPRVAL { get; set; }

        [StringLength(16777215)]
        public string VARS_PROC { get; set; }

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
