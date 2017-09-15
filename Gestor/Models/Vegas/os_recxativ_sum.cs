namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_recxativ_sum")]
    public partial class os_recxativ_sum
    {
        [Key]
        public Guid UUIDRXASUM { get; set; }

        public Guid IDOS { get; set; }

        public Guid IDATIVIDADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODRECURSO { get; set; }

        public decimal QTD { get; set; }

        public decimal VALOR { get; set; }

        public decimal VALORTOT { get; set; }

        public decimal QTDREAL { get; set; }

        public decimal VALORTOTREAL { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPODISTSTD { get; set; }

        [StringLength(500)]
        public string CNSTREE { get; set; }

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
