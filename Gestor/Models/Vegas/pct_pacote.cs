namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pct_pacote")]
    public partial class pct_pacote
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDPACOTE { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDSEQ_REG { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(11)]
        public string FLUXO { get; set; }

        public int? FLU_RESP { get; set; }

        public DateTime? FLU_MOM { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(9)]
        public string TPOPERA { get; set; }

        public int? PESSOAOPERA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TPPACOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORIG_RESP { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORIG_PES { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DES_RESP { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DES_PES { get; set; }

        public Guid? NUMPAC { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal PESO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string TAMANHO { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal VALOR { get; set; }

        public Guid? LINKPAI { get; set; }

        public Guid? LINKMASTER { get; set; }

        public DateTime? ENV_TORPMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 11, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
