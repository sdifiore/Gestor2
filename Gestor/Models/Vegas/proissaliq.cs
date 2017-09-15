namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proissaliqs")]
    public partial class proissaliq
    {
        [Key]
        [Column(Order = 0)]
        public Guid CODPROISSALIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODISS { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string PDV_TRIB { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal PDV_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CFOP { get; set; }

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
