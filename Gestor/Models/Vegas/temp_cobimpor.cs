namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_cobimpor")]
    public partial class temp_cobimpor
    {
        [Key]
        public int IDIMPORTA { get; set; }

        public Guid? UUIDLOTE { get; set; }

        public long? NOSSONUMER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string SEQ_EXTERNA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VENCIMENTO { get; set; }

        public decimal VALORREAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATACRED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAPAG { get; set; }

        public decimal VALORPAG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONVENIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string NUMDOC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string BANCO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string AGENCIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string AGENCIADIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(12)]
        public string CONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONTADIG { get; set; }

        public decimal MULTA { get; set; }

        public decimal TAXA { get; set; }

        public decimal VALORLIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string ARQUIVO { get; set; }

        public int? MOTIVO { get; set; }

        public int? OCORRENCIA { get; set; }

        public DateTime? IMPORTAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string IMPORTAUSU { get; set; }

        public DateTime? BAIXAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string BAIXAUSU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LIMPEZA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
