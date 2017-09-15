namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_empresa")]
    public partial class base_empresa
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODEMPRESA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        public int? ORDEM { get; set; }

        public int? IDRESP { get; set; }

        public int? IDPESSOA { get; set; }

        public int? IDCONTADOR { get; set; }

        [StringLength(16777215)]
        public string DESCRICAO1 { get; set; }

        [StringLength(16777215)]
        public string DESCRICAO2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(120)]
        public string CNSTREE { get; set; }

        [Column(TypeName = "mediumblob")]
        public byte[] LOGO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string LOGO_TPI { get; set; }

        [Column(TypeName = "mediumblob")]
        public byte[] FOTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FOTO_TPI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PADRAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSPADRAO { get; set; }

        [StringLength(16777215)]
        public string VARIAVEIS { get; set; }

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
