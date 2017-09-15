namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.contresmes")]
    public partial class contresme
    {
        [Key]
        public int IDRESULT { get; set; }

        public int IDCONTRATO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MES { get; set; }

        public decimal CONTVALOR { get; set; }

        public decimal CONTHORA { get; set; }

        public int? CONTATEND { get; set; }

        public decimal TOTHORA { get; set; }

        public int TOTATEND { get; set; }

        public decimal ATENDHORA { get; set; }

        public int? ATENDLANC { get; set; }

        public decimal OSHORA { get; set; }

        public int? OSLANC { get; set; }

        public decimal DESLOCAHORA { get; set; }

        public int? DESLOCALANC { get; set; }

        public decimal RETRABHORA { get; set; }

        public int? RETRABLANC { get; set; }

        public decimal DESENVHORA { get; set; }

        public int? DESENVLANC { get; set; }

        public int? VISITAS { get; set; }

        [StringLength(16777215)]
        public string OBS { get; set; }

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
