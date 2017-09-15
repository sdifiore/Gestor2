namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.profisc_recupera")]
    public partial class profisc_recupera
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDRECUPERA { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(9)]
        public string TRIBUTO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(999)]
        public string OPERACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [StringLength(16777215)]
        public string CODCLFISCAL { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(1)]
        public string RECUPERAR { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal REC_PERC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNF_TRIB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 6, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
