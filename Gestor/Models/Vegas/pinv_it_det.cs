namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pinv_it_det")]
    public partial class pinv_it_det
    {
        [Key]
        public Guid IDITDT { get; set; }

        public Guid IDITEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string TIPOMOV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DOCUMENTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
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

        public decimal QTD { get; set; }

        public decimal CUSTO { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string GERENCIAL { get; set; }

        public Guid? ORIGEMID { get; set; }

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
