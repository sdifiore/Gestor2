namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.geddocarq")]
    public partial class geddocarq
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDARQUIVO { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDDOC { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(100)]
        public string NOMEARQ { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(100)]
        public string TITULO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1073741823)]
        public string BINARIO { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VERSAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string EXTENSAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string REFVERSAO { get; set; }

        [StringLength(16777215)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string RESERVAUSU { get; set; }

        public DateTime? RESERVAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string PUBLICAUSU { get; set; }

        public DateTime? PUBLICAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string HASHARQUIVO { get; set; }

        public int? SIZEARQUIVO { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "char")]
        [StringLength(250)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string ORIGEMDESC { get; set; }

        [StringLength(16777215)]
        public string VARIAVEIS { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 8, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
