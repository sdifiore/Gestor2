namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.op")]
    public partial class op
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CODINTERNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDOPSEQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTABERTURA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO { get; set; }

        public int? RESPONSAVEL { get; set; }

        public int? CLIENTE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal VL_GERPREVPC { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal VL_MEDPREVPC { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal VL_GERPREVINS { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal VL_MEDPREVINS { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal VL_GERREALPC { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal VL_MEDREALPC { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal VL_GERREALINS { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal VL_MEDREALINS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INIPREV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FINPREV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_INIREAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DT_FINREAL { get; set; }

        public DateTime? DT_IMPRES { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal CUSTO_CONSUMO { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal CUSTO_PROCESSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 13, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
