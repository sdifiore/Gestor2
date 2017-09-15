namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prorec_rec_custo")]
    public partial class prorec_rec_custo
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDCUSTO { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UUIDRECURSO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DATA { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal CUSTO { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(9)]
        public string TIPOATV { get; set; }

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
