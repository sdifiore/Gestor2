namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.rot_provtpderiv")]
    public partial class rot_provtpderiv
    {
        [Key]
        public Guid IDPROVTPDERIV { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string PROV_TIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string DERIV_TIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string DERIV_PREFIXO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DERIV_CLASSFECHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DERIV_OBRIG { get; set; }

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
