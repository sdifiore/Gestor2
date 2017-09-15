namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gedtipdoc")]
    public partial class gedtipdoc
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string PER_INSERIR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string PER_EDITAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string PER_VISUALIZAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string PER_VISVERANT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string PER_PUBLICAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string PER_TRIGGER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string FLUXOPUB { get; set; }

        [StringLength(16777215)]
        public string EXPR_PRECAMPOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string SAVECOPYSERVER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FAZMORTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSPADRAO { get; set; }

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
