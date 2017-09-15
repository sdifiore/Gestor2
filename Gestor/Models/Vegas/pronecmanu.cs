namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pronecmanu")]
    public partial class pronecmanu
    {
        [Key]
        public int IDNECMANU { get; set; }

        public int IDNECPRIN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(105)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODUNIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODLOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string LOTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }

        public int? IDNECCALCREF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AGRUPAMENTO { get; set; }

        public decimal QTDNECESSARIA { get; set; }

        public decimal QTDLOTE { get; set; }

        public decimal QTDESTOQUE { get; set; }

        public decimal QTDRESERVA { get; set; }

        public decimal QTDEMPROC { get; set; }

        public decimal QTDDISPONIVEL { get; set; }

        public decimal QTDFALTA { get; set; }

        public decimal QTDSUGEST { get; set; }

        public decimal QTDREQUIS { get; set; }

        public Guid? IDREQUIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string RASTREABTAB { get; set; }

        public Guid? RASTREABID { get; set; }

        public Guid? IDPLNPRODDT { get; set; }

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
