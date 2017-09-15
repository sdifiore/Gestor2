namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.ven_avalia")]
    public partial class ven_avalia
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDAVALIA { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UUIDPEDIDO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDREGRA { get; set; }

        public int? ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string STATUS { get; set; }

        public DateTime? ULT_VERIFICA { get; set; }

        [StringLength(16777215)]
        public string INFOS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string APROVA_TIPO { get; set; }

        public DateTime? APROVA_MOMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string APROVA_USUARIO { get; set; }

        [StringLength(16777215)]
        public string APROVA_OBS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
