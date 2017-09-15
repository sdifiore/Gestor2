namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.un_pesquisado")]
    public partial class un_pesquisado
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPESQUISADO { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDPESQUISADOSEQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string IDPESQUISA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? IDRESP { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIGEMID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string ORIGEMDESC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 3, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
