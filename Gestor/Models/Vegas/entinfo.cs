namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.entinfo")]
    public partial class entinfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDINFO { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDENTRADA { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(9)]
        public string IDPESQUISA { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(20)]
        public string IDPESQINFO { get; set; }

        [StringLength(16777215)]
        public string VALOR { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 5, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
