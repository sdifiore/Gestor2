namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cep_logra")]
    public partial class cep_logra
    {
        [Key]
        public int IDLOGR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CEP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(70)]
        public string NOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(70)]
        public string COMPLEMEN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(70)]
        public string BAIRROINI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(70)]
        public string BAIRROFIN { get; set; }

        public int? IDBAIRROINI { get; set; }

        public int? IDBAIRROFIN { get; set; }

        public int? IDCIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(70)]
        public string CIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODUF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(70)]
        public string UF { get; set; }

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
    }
}
