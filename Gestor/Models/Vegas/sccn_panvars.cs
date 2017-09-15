namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sccn_panvars")]
    public partial class sccn_panvars
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPANVARS { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(40)]
        public string VARNOME { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(120)]
        public string VARDESC { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid IDPANEL { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDEM { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(1)]
        public string VARTIPO { get; set; }

        [StringLength(16777215)]
        public string VARVALOR { get; set; }

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

        [Key]
        [Column("_UCRC_", Order = 7, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
