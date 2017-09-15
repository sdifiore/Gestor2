namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.mi_tpmov")]
    public partial class mi_tpmov
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
        [StringLength(1)]
        public string FLAG_PEDIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FLAG_PRODUCAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string FLUXO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONTRAPARTIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONF_RESTR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONF_COMPL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string HAB_TRANSF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string HAB_ESTORNO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string PER_ESTORNO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ZERA_LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ZERA_TPACERTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string STATUS_FINAL { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSSINCCHK { get; set; }
    }
}
