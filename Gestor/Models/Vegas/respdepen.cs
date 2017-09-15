namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.respdepen")]
    public partial class respdepen
    {
        [Key]
        public int IDDEPEN { get; set; }

        public int IDRESP { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string NOME { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NASC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string SEXO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string APELIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CPF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string RG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string DDI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(11)]
        public string FONE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(11)]
        public string FAX { get; set; }

        [Column(TypeName = "char")]
        [StringLength(11)]
        public string CELULAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(12)]
        public string VOIP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

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
