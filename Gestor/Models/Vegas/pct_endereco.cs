namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pct_endereco")]
    public partial class pct_endereco
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDENDERECO { get; set; }

        public Guid? UIDPACOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FLUXOEND { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOEND { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CEP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LOGRADOURO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string ENDERECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string NUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string BAIRRO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODMUNICIPIO { get; set; }

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
        [Column(Order = 1, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 2, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
