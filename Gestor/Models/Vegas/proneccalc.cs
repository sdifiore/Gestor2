namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.proneccalc")]
    public partial class proneccalc
    {
        [Key]
        public int IDNECCALC { get; set; }

        public int? IDPAI { get; set; }

        public int IDNECPRIN { get; set; }

        public int IDNECPROD { get; set; }

        public int? IDCALCTAR { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(105)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODUNIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string GRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AGRUPAMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string N_SOMA_TEMP { get; set; }

        public decimal QTDNECESSARIA { get; set; }

        public decimal QTDLOTE { get; set; }

        public decimal QTDESTOQUE { get; set; }

        public decimal QTDESTSEGU { get; set; }

        public decimal QTDRESERVA { get; set; }

        public decimal QTDEMPROC { get; set; }

        public decimal QTDCONSTEMP { get; set; }

        public decimal QTDREQTEMP { get; set; }

        public decimal QTDDISPFISI { get; set; }

        public decimal QTDDISPVIRT { get; set; }

        public decimal QTDFALTA { get; set; }

        public decimal QTDACONSUMIR { get; set; }

        public decimal QTDAREQUIS { get; set; }

        public decimal QTDREQPOSS { get; set; }

        public decimal QTD { get; set; }

        public decimal QTDPAI { get; set; }

        public decimal CUSTO_PROC { get; set; }

        public decimal CUSTO_GER { get; set; }

        public decimal CUSTO_MED { get; set; }

        public decimal CUSTO_ULTC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string RASTREABTAB { get; set; }

        public Guid? RASTREABID { get; set; }

        public Guid? IDPLNPRODDT { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(20)]
        public string NOMEIMG { get; set; }

        public int ORDEM { get; set; }

        public int POSICAO { get; set; }

        public int NIVEL { get; set; }

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
