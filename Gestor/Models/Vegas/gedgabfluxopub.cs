namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gedgabfluxopub")]
    public partial class gedgabfluxopub
    {
        [Key]
        public int IDGABFLUXO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string IDFLUXO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string IDATIVIDADE { get; set; }

        public int? RESPONSA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DEPARTAMEN { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LIBERAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
