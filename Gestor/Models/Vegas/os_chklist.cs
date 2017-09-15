namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_chklist")]
    public partial class os_chklist
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDCHKLIST { get; set; }

        [Key]
        [Column(Order = 1)]
        public int SEQIDCHKLIST { get; set; }

        public Guid OS { get; set; }

        public Guid? ATIVIDADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string OBRIGATORIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAPREV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string LIBERA_DPTO { get; set; }

        public int? LIBERA_RESP { get; set; }

        public DateTime? LIBERA_MOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string OK_DPTO { get; set; }

        public int? OK_RESP { get; set; }

        public DateTime? OK_MOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string OK_CODRESULT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string OK_RESULTADO { get; set; }

        [StringLength(16777215)]
        public string OK_OBS { get; set; }

        public Guid? SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string DESCRITIVO { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [StringLength(16777215)]
        public string INSTRUCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        public Guid? ORIGEMID { get; set; }

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
