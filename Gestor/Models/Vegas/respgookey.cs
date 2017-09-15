namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.respgookey")]
    public partial class respgookey
    {
        [Key]
        public int IDGOOKEY { get; set; }

        public int IDRESP { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string SCOPE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string ACCESS_TOKEN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string TOKEN_TYPE { get; set; }

        public int EXPIRES_IN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string REFRESH_TOKEN { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
