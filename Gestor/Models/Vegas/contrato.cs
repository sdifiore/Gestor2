namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.contratos")]
    public partial class contrato
    {
        [Key]
        public int IDCONTRATO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FAMILIA { get; set; }

        public int? CLIENTE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PRIMEIRADATA { get; set; }

        public int? RESPONSA { get; set; }

        [StringLength(16777215)]
        public string PROPOSTA { get; set; }

        [Column("CONTRATO")]
        [StringLength(16777215)]
        public string CONTRATO1 { get; set; }

        [StringLength(16777215)]
        public string MEMORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

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
