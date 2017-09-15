namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sccn_ggetuvars")]
    public partial class sccn_ggetuvars
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDGGETUVAR { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(40)]
        public string VARNOME { get; set; }

        [StringLength(16777215)]
        public string VARVALOR { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid IDGADGET { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDRESP { get; set; }

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

        [Key]
        [Column("_UCRC_", Order = 5, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
