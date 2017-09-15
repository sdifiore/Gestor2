namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_atividade")]
    public partial class os_atividade
    {
        [Key]
        public Guid IDATIVIDADE { get; set; }

        public Guid OS { get; set; }

        public int NUMATIVIDADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(48)]
        public string ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        public int? RESPONSAVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODDNA { get; set; }

        public decimal TEMPO { get; set; }

        public decimal DURACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PREV_LOCAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INIPREV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FINPREV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_DEADLINE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATV_FATOPLAN { get; set; }

        public decimal? TZERO { get; set; }

        public decimal? TAUXILIAR { get; set; }

        public decimal? TGANHO { get; set; }

        public DateTime? DT_REALLIBERAMOM { get; set; }

        public DateTime? DT_INIREAL { get; set; }

        public DateTime? DT_REALCONCLMOM { get; set; }

        public DateTime? DT_FINREAL { get; set; }

        public DateTime? DT_REALSUSPMOM { get; set; }

        public decimal AVANCO { get; set; }

        public decimal AVANCO_D { get; set; }

        public DateTime? POSMOM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? POSDTFIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string POSUSUARIO { get; set; }

        public int BL_DURACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BL_INIPREV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BL_FINPREV { get; set; }

        public decimal? BL_TEMPO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        public Guid? SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string CNSTREE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPORESTR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATARESTR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string PRIORIDADE { get; set; }

        public int? HOMOLOGADOR { get; set; }

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
        [Required]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }
    }
}
