namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.prochklist")]
    public partial class prochklist
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDCHKLIST { get; set; }

        [Key]
        [Column(Order = 1)]
        public int SEQIDCHKLIST { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
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
        [StringLength(100)]
        public string OK_RESULTADO { get; set; }

        public Guid? SUPERIOR { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [StringLength(16777215)]
        public string INSTRUCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 5, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
