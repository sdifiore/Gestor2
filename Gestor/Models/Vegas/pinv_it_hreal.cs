namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pinv_it_hreal")]
    public partial class pinv_it_hreal
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDITHREAL { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDITEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CONTEXTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string TIPOMOV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DOCUMENTO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNF_PROP_POSS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CLFISCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        public DateTime? MOMENTO { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal QTD { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(1)]
        public string QTD_INV { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal CUSTO { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal POS_ESTOQUE { get; set; }

        public decimal? CUSTO_MEDIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ALTERA_CM { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 9, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
