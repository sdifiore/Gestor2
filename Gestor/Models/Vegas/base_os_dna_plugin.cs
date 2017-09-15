namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_os_dna_plugin")]
    public partial class base_os_dna_plugin
    {
        [Key]
        public Guid IDDNAPLUGIN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODDNA { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string ATIVADO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODEVENTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(250)]
        public string STATUS_AVAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string DATAAVALIADA { get; set; }

        public int DIAS { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string NOMEPROC { get; set; }

        [StringLength(16777215)]
        public string VARIAVEIS { get; set; }

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
