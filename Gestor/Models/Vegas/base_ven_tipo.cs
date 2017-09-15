namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_ven_tipo")]
    public partial class base_ven_tipo
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOPRECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string GRPALTPRECO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string GERA_SAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SAI_TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FECHA_SAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SAI_STATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string GERA_NOTA_COMPL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FAT_OPERACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [StringLength(16777215)]
        public string INFO { get; set; }

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
