namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pescontabanco")]
    public partial class pescontabanco
    {
        [Key]
        public int IDCONTABC { get; set; }

        public int? IDPESSOA { get; set; }

        public int? IDDEPEND { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string BANCO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(6)]
        public string AGENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string AGENDIG { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string NUMCONTA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(3)]
        public string NUMCONTADIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string TITULAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CNPJ_CPF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string TIPOCONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string OBS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PADRAO { get; set; }

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
