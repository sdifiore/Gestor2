namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_profisc_piscf_oper")]
    public partial class base_profisc_piscf_oper
    {
        [Key]
        public Guid UUIDPISCF { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string CODTABELA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string GRUPOS { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(3)]
        public string CODIGOOPER { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(255)]
        public string DESCRICAO { get; set; }

        [StringLength(300)]
        public string CST { get; set; }

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
