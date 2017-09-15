namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ped_recorrencia")]
    public partial class ped_recorrencia
    {
        [Key]
        public int IDCOMREC { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(3)]
        public string EXECUCAO { get; set; }

        public int DIAVENC { get; set; }

        [Column(TypeName = "date")]
        public DateTime INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPOPED { get; set; }

        public int PESSOA { get; set; }

        public int? IDCONTRATO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ORIGDPTO { get; set; }

        public int? ORIGRESP { get; set; }

        public Guid? REPRESEN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string FORMAPG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOTRANSP { get; set; }

        public int? TRANSPORTA { get; set; }

        public int? SOLICITA { get; set; }

        public int? RESPAPROVA { get; set; }

        public int? RESPCOMPRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string STATUSPED { get; set; }

        public decimal VALOR { get; set; }

        public decimal DESCONTO { get; set; }

        public decimal ACRESCIMO { get; set; }

        public decimal SEGURO { get; set; }

        public decimal FRETE { get; set; }

        public decimal OUTROS { get; set; }

        public decimal VALORTOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string REF_INDIC { get; set; }

        [StringLength(16777215)]
        public string NEGOCIACAO { get; set; }

        [StringLength(16777215)]
        public string RECEBIMENT { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

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
