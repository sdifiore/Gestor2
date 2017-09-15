namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cpagimpret")]
    public partial class cpagimpret
    {
        [Key]
        public int IDRETORNO { get; set; }

        public int IDIMPORTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string TPOPERACAO { get; set; }

        public int? OCORRENCIA { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        public DateTime? IMPMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string IMPUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
