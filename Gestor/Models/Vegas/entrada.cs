namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.entrada")]
    public partial class entrada
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDENTRADA { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDENTSEQ { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DATA { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(9)]
        public string TIPOENTRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(25)]
        public string DOCUMENTO { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DEPTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FORMAPG { get; set; }

        public int? COMPRADOR { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PESSOA { get; set; }

        public int? IDCONTRATO { get; set; }

        public int? TRANSPORTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string TRSPPLACA { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal TRSPQTD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string TRSPESPECI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string TRSPPEBRUT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string TRSPPELIQU { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal VALOR { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal DESCONTO { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ACRESCIMO { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal IPI { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal ICMSSUB { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal SEGURO { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal FRETE { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal OUTROS { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal VALORDESPADUANE { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal VALORIOF { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal VALORII { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal VALORTOT { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal VALORREF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string REF_INDIC { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal GERSEGURO { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal GERFRETE { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal GEROUTROS { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string BAIXAUSU { get; set; }

        public int? BAIXARESP { get; set; }

        public int? IDNFE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string ORIGEMLOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        [StringLength(16777215)]
        public string FISC_INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CALCULADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string EXPFINAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ROMANEIO { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 24, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
