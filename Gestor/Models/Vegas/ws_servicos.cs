namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ws_servicos")]
    public partial class ws_servicos
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDSERVICO { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDAGRUPSERV { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(80)]
        public string NOME { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(120)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string DESCRITIVO { get; set; }

        [StringLength(16777215)]
        public string EXEMPLO { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(60)]
        public string PROCESSO { get; set; }

        [StringLength(16777215)]
        public string VARIAVEIS { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(40)]
        public string ESTRUT_IN { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "char")]
        [StringLength(40)]
        public string ESTRUT_OUT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LOGDATAIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LOGDATAOUT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string AUTENTBASICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 8, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
