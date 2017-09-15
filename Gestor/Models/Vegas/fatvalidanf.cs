namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.fatvalidanf")]
    public partial class fatvalidanf
    {
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string GRUPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string FLUXO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string CHECAGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVO { get; set; }

        public int ORDEM { get; set; }

        [Required]
        [StringLength(16777215)]
        public string FORMULA { get; set; }

        [Required]
        [StringLength(16777215)]
        public string MENSAGEM { get; set; }

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
