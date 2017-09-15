namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.un_loggeral")]
    public partial class un_loggeral
    {
        [Key]
        public Guid UUIDLOG { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOLOG { get; set; }

        public int IDLICLOCAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string IDEXTERNO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSSINCCHK { get; set; }

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
