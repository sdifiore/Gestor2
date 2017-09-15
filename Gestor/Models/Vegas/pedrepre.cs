namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pedrepre")]
    public partial class pedrepre
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDREPRESEN { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDREPRSEQ { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(20)]
        public string DESCRICAO { get; set; }

        public int? PESSOA { get; set; }

        public int? DEPENDENTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string PRAZO { get; set; }

        public int? PRAZO_ENTREGA { get; set; }

        public int? PRAZO_PGTO { get; set; }

        public int? PRAZO_VISITA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string DEPARTAMEN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string FAMILIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string GRUPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string MARCA { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
