namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ivc_packlist")]
    public partial class ivc_packlist
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDPACKLIST { get; set; }

        public Guid? UIDINVOICE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TPEMBALAGEM { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal QTD { get; set; }

        public int? VOLUME { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal PESOLIQ { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal PESOBRUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string MEDIDA { get; set; }

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
