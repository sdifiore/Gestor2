namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prorec_recurso")]
    public partial class prorec_recurso
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDRECURSO { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDSEQ { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CENTROTRAB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODHORARIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        public int? IDEQUIPA { get; set; }

        public int? IDRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
