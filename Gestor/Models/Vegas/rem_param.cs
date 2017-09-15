namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.rem_param")]
    public partial class rem_param
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDPARAM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOINFO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal QUANTIDADE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAINI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAFIN { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLCONTADESTINO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLCONTAORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTODESTINO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTOORIGEM { get; set; }

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
