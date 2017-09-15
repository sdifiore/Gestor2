namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pinv_fecha")]
    public partial class pinv_fecha
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDFECHA { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(9)]
        public string CODTPFECHA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAREF { get; set; }

        public DateTime? MOMINI { get; set; }

        public DateTime? MOMFIN { get; set; }

        public DateTime? POSESTFIN { get; set; }

        public DateTime? PUBLICAMOM { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 3, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
