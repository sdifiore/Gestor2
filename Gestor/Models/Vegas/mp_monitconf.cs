namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.mp_monitconf")]
    public partial class mp_monitconf
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CODMONITCONF { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVO { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string PROCESSO { get; set; }

        [StringLength(16777215)]
        public string VARIAVEIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string EXEC_PADRAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(255)]
        public string PER_GRUPO { get; set; }

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
