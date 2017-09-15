namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.rot_provgab")]
    public partial class rot_provgab
    {
        [Key]
        public Guid IDPROVGAB { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TPOCOR { get; set; }

        public int IDRESP { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string REFERENCIA { get; set; }

        [StringLength(16777215)]
        public string MENSAGEM { get; set; }

        public decimal TEMPOPREVISTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PADRAO { get; set; }

        public int? DIASPRAZO { get; set; }

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
