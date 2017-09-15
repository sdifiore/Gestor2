namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_ger_juros")]
    public partial class base_ger_juros
    {
        [Key]
        public int IDJUROS { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODJUROS { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        public decimal J_JUROS { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string J_DIAMEN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string J_SIMPCOMP { get; set; }

        public int J_DIACAREN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string J_FORAMES { get; set; }

        public decimal M_MULTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string M_MULTAVLR { get; set; }

        public int M_DIACAREN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string M_FORAMES { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENCBASE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAINI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAFIN { get; set; }

        public int DIAINI { get; set; }

        public int DIAFIN { get; set; }

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
