namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.movfci")]
    public partial class movfci
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDFCI { get; set; }

        public int? IDPROC { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal VALPARCELAIMP { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal PRECOVENDA { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal CONTEUDOIMP { get; set; }

        [StringLength(16777215)]
        public string MEMO { get; set; }

        public DateTime? MOMGERACAOFCI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(200)]
        public string ARQUIVO { get; set; }

        public DateTime? MOMRETORNOFCI { get; set; }

        public Guid? FCIPROTOCOLO { get; set; }

        public Guid? FCINUMERO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 6, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
