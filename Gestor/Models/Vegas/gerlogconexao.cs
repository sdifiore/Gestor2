namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gerlogconexao")]
    public partial class gerlogconexao
    {
        [Key]
        public int IDLOGCON { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string ORIGEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        public DateTime? MOMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(25)]
        public string ACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OK { get; set; }

        public int? DURACAO { get; set; }

        [StringLength(1073741823)]
        public string DESCRITIVO { get; set; }

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
