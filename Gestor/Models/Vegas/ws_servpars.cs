namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ws_servpars")]
    public partial class ws_servpars
    {
        [Key]
        public Guid IDSERVPAR { get; set; }

        public Guid IDSERVICO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string NOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string DESCRITIVO { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string FLUXO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string CODTPDADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ESTRUTDADO { get; set; }

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
