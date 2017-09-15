namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.cotforne")]
    public partial class cotforne
    {
        [Key]
        public int IDFORNE { get; set; }

        public int IDCOTACAO { get; set; }

        public int? FORNECEDOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string NOME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string CONTATO { get; set; }

        public int? ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOENVIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTENVIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTPREVRET { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTRECEB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTVALID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DTPREVENTR { get; set; }

        [StringLength(16777215)]
        public string HISTORICO { get; set; }

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
