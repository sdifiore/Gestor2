namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.fatserie")]
    public partial class fatserie
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODSERIE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string RETENCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PADRAOEMPR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(2)]
        public string MODELO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string SERIECODIGO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INICIO { get; set; }

        public int NUMERO { get; set; }

        public int NUMMAX { get; set; }

        public int ULTFAT { get; set; }

        public DateTime? ULTMOM { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [StringLength(16777215)]
        public string VISUAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

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
