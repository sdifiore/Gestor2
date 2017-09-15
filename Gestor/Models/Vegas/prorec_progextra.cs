namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prorec_progextra")]
    public partial class prorec_progextra
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDPROGEXTRA { get; set; }

        public Guid? UUIDRECURSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        public DateTime? MOMINI { get; set; }

        public DateTime? MOMFIN { get; set; }

        [Key]
        [Column(Order = 1)]
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

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 3, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
