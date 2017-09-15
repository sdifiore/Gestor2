namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pescredit")]
    public partial class pescredit
    {
        [Key]
        public int IDCREDIT { get; set; }

        public int IDPESSOA { get; set; }

        public int? IDDEPEN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOCRED { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATAINI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAFIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LIBERACAO { get; set; }

        public decimal VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BLOQMOTIVO { get; set; }

        public DateTime? BLOQUEIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string BLOQUSU { get; set; }

        [StringLength(16777215)]
        public string INFORMACAO { get; set; }

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
