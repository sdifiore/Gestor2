namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pinv_item")]
    public partial class pinv_item
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDITEM { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDFECHA { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CLFISCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODCLCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal F_QTDANT { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal F_ENTRADA { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal F_SAIDA { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal F_OPENTR { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal F_OPSAID { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal F_TRANSF { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal F_CONSUM { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal F3_QTDANT { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal F3_ENTRADA { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal F3_SAIDA { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal F_CUSTOANT { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal F_CUSTO { get; set; }

        [StringLength(16777215)]
        public string F_OBSERVACAO { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal R_QTDANT { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal R_QTDANT_BD { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal R_ENTRADA { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal R_SAIDA { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal R_OPENTR { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal R_OPSAID { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal R_TRANSF { get; set; }

        [Key]
        [Column(Order = 23)]
        public decimal R_ACERTOS { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal R_AJUSTES { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal R_OUTROS { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal R_QTD_BD { get; set; }

        [Key]
        [Column(Order = 27)]
        public decimal R_CUSTOANT { get; set; }

        [Key]
        [Column(Order = 28)]
        public decimal R_CUSTO { get; set; }

        [StringLength(16777215)]
        public string R_OBSERVACAO { get; set; }

        [StringLength(16777215)]
        public string LOGEDIT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 30, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
