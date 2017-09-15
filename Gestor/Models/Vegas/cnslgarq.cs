namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cnslgarq")]
    public partial class cnslgarq
    {
        [Key]
        public int IDLOG { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string ARQUIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string CAMPOCHAVE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string CAMPOVALOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string OPERACAO { get; set; }

        public DateTime CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSSINCCHK { get; set; }

        public DateTime? CNSSINCMOM { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }
    }
}
