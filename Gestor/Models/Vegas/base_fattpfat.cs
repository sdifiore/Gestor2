namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_fattpfat")]
    public partial class base_fattpfat
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
        [StringLength(9)]
        public string TIPOSAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string STATSAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string GERASAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODOPERACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BUSCARPRECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string GERACRECEBER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NAOFCH_NF_INVALIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CALCNOBRIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CALCNCALC { get; set; }

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
