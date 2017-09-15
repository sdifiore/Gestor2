namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_aprova")]
    public partial class ven_aprova
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDAPROVA { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UUIDPEDIDO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        public int? ORDEM { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(1)]
        public string FORMA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string USUAPROVA { get; set; }

        public DateTime? MOMAPROVA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string USUREPROVA { get; set; }

        public DateTime? MOMREPROVA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string MOTIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string BLOQMOT { get; set; }

        public DateTime? BLOQMOM { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string BLOQDETALHE { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string DETALHE { get; set; }

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
    }
}
