namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.op_log")]
    public partial class op_log
    {
        [Key]
        public int IDLOG { get; set; }

        public Guid IDOP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DETALHE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }
    }
}
