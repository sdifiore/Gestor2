namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_finplano")]
    public partial class base_finplano
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string DEB_CRED { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(120)]
        public string CNSTREE { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FLAGPLANFINAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODDRE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSPADRAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CNSALIAS { get; set; }

        [StringLength(16777215)]
        public string CNSAJUDA { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

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
