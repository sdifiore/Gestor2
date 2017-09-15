namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.op_tarefa")]
    public partial class op_tarefa
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDOPTAR { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDOPTARSEQ { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid IDOP { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(9)]
        public string CODTAREFA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal PREVSETUP { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal PREVTEMPO { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal REALSETUP { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal REALTEMPO { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal VALORBASE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AGRUPAMENTO { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int POSICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 11, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
