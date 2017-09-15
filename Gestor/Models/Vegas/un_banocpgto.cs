namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.un_banocpgto")]
    public partial class un_banocpgto
    {
        [Key]
        public int IDOCORR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODBANCO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(4)]
        public string OCORPGTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BAIXADEB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string PROCESSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string METODO { get; set; }

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
