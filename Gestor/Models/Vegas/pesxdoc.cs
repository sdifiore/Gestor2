namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pesxdoc")]
    public partial class pesxdoc
    {
        [Key]
        public int IDDOC { get; set; }

        public int IDPESSOA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(3)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string DOCUMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UF { get; set; }
    }
}
