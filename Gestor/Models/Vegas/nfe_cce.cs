namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.nfe_cce")]
    public partial class nfe_cce
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDCCE { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDSEQREQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public DateTime? MOMENTO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIGEMTAB { get; set; }

        public int? ORIGEMID { get; set; }

        [StringLength(16777215)]
        public string CORRECAO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NFESEQUENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string NFENUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string NFEPROTOCOLO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string NFESTATUS { get; set; }

        public DateTime? NFESTATMOM { get; set; }

        [StringLength(16777215)]
        public string NFERETORNO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 5, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
