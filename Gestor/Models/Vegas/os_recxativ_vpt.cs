namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_recxativ_vpt")]
    public partial class os_recxativ_vpt
    {
        [Key]
        public Guid UUIDRXAVPT { get; set; }

        public Guid UUIDRXASUM { get; set; }

        public Guid IDOS { get; set; }

        public Guid IDATIVIDADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODRECURSO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string ORIGEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOFATO { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA { get; set; }

        public decimal QTD { get; set; }

        public decimal VALOR { get; set; }

        public decimal VALORTOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [StringLength(500)]
        public string CNSTREE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTO { get; set; }

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
