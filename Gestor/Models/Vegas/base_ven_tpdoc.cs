namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_ven_tpdoc")]
    public partial class base_ven_tpdoc
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTPDOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string FORMA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NAO_FISCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
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

        [StringLength(16777215)]
        public string VARIAVEIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string NOMEPROC { get; set; }

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
