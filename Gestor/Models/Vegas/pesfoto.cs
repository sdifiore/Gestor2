namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pesfoto")]
    public partial class pesfoto
    {
        [Key]
        public int IDFOTO { get; set; }

        public int IDPESSOA { get; set; }

        public int? IDDEPEN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOFOTO { get; set; }

        [Column(TypeName = "mediumblob")]
        public byte[] FOTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FOTO_TPI { get; set; }

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
