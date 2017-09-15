namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.dic_scr_arqcampos")]
    public partial class dic_scr_arqcampos
    {
        [Key]
        public int IDCAMPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string CODTABELA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string CAMPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string TIPO { get; set; }

        public int POS_INI { get; set; }

        public int TAMANHO { get; set; }

        public int DECIMAIS { get; set; }

        [StringLength(16777215)]
        public string FORMATO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string VALORFIXO { get; set; }

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
