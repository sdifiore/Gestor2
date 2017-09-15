namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_germoedaind")]
    public partial class base_germoedaind
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string IDINDICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string TITULO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string PERIODO { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        [StringLength(16777215)]
        public string SCRIPT { get; set; }

        [StringLength(16777215)]
        public string CNSAJUDA { get; set; }

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
