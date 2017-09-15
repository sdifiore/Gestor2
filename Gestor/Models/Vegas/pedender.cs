namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pedender")]
    public partial class pedender
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDENDER { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDPEDIDO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(9)]
        public string TIPOENDER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CEP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string LOGRADOURO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ENDERECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(6)]
        public string NUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string BAIRRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string CIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ESTADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string PAIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CPOSTAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 5, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
