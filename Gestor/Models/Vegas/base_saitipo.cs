namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_saitipo")]
    public partial class base_saitipo
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ST2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string FECHA_GRUPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FOCO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FISC_INV_TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NAO_EXP_FINAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NAO_MOV_ESTOQUE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OBRIGA_DOCUMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FAT_TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FAT_STATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FAT_OPERACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FAT_OPERACOMPLE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FAT_GERANUMFAT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FECHA_NOTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string FAT_SERIE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(250)]
        public string FAT_DPTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string TRANSFERENCIA { get; set; }

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
