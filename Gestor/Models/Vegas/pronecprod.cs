namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pronecprod")]
    public partial class pronecprod
    {
        [Key]
        public int IDNECPROD { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODLOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        public int IDNECPRIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_NECESSID { get; set; }

        public decimal QTD { get; set; }

        public decimal QTDJAPROC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string P_N_CHK_LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string P_N_CHK_EST { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string P_N_CHK_PROC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string P_N_CHK_PREV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string P_N_SOMA_PREV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string F_N_CHK_LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string F_N_CHK_EST { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string F_N_CHK_DISP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string F_N_CHK_PROC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string F_N_CHK_PREV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string F_N_SOMA_PREV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL_ABASTECI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CODORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIGEMDESC { get; set; }

        public Guid? IDPLNPRODDT { get; set; }

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
