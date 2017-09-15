namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_proicm")]
    public partial class base_proicm
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODICM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string ALIAS { get; set; }

        public decimal ALIQ { get; set; }

        public decimal REDUCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(2)]
        public string TRIBUTACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string SUBST { get; set; }

        public decimal ST_VAREJO { get; set; }

        public decimal ST_PAUTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string PDV_TRIB { get; set; }

        public decimal PDV_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP { get; set; }

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
