namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.mi_carrinho")]
    public partial class mi_carrinho
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDCAB { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IDCAB { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(9)]
        public string TIPOMOV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAPEDIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCALATENDE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCALSOLICITA { get; set; }

        public DateTime? ENVIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ENVIOUSU { get; set; }

        public DateTime? RECEBIMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string RECEBUSU { get; set; }

        public DateTime? FECHAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string FECHAUSU { get; set; }

        public int? RESP_DONO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DPTO_DONO { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

        public Guid? LINK { get; set; }

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
        [Column(Order = 3, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSSINCCHK { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
