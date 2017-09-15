namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prco_procmov")]
    public partial class prco_procmov
    {
        [Key]
        public int IDPROCMOV { get; set; }

        public int IDPROCESSA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODREGRA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string RESPORIGEM { get; set; }

        public Guid RESPID { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string RESPNOME { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(150)]
        public string DESCRICAO { get; set; }

        public decimal? PCENT_USUAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(150)]
        public string COMPLEMENTO { get; set; }

        public decimal? PCENT_CONSID { get; set; }

        public decimal? VALOR_INFO { get; set; }

        public decimal VALOR_CONSID { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

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
