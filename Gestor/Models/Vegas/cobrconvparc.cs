namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cobrconvparc")]
    public partial class cobrconvparc
    {
        [Key]
        public int IDOPPARC { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODCONV { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        public int PARCELAS { get; set; }

        public decimal VALOR { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal VALORLIMITE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string ORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string FILT_CATEG { get; set; }

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
