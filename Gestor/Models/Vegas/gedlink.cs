namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gedlink")]
    public partial class gedlink
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDLINK { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDDOC { get; set; }

        public Guid? IDARQUIVO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(40)]
        public string ORITAB { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(40)]
        public string ORIID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIDES { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORITAB2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIID2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIDES2 { get; set; }

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
