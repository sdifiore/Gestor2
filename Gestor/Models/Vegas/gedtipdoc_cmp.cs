namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gedtipdoc_cmp")]
    public partial class gedtipdoc_cmp
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDTIPODOCCMP { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(20)]
        public string CODTIPODOC { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(20)]
        public string CAMPO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string BANDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(120)]
        public string HINT { get; set; }

        public int? ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONTEXTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OBRIGATORIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string READONLY { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(1)]
        public string TIPODADO { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TAMANHO { get; set; }

        public int? DECIMAIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(120)]
        public string MASCARA { get; set; }

        [StringLength(16777215)]
        public string VALORES { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string VALORES_ALT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PADRAO_PORVAL { get; set; }

        [StringLength(16777215)]
        public string PADRAO { get; set; }

        [StringLength(16777215)]
        public string VALID { get; set; }

        [StringLength(16777215)]
        public string SCRIPT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 7, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
