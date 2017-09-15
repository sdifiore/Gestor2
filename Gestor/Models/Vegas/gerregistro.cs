namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gerregistro")]
    public partial class gerregistro
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(200)]
        public string K_INT_NAME { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string K_DESC { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(200)]
        public string K_NAME { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string K_ENTITY { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string K_ROOT { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(200)]
        public string K_INT_PARENT { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string K_DATATYPE { get; set; }

        [StringLength(16777215)]
        public string K_DATAVALUE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string K_KEYTYPE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
