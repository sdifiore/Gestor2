namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_un_cartao_ocor")]
    public partial class base_un_cartao_ocor
    {
        [Key]
        public int IDOCOR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODOPERADORA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(3)]
        public string OCORRENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

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
