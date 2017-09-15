namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gerferiado")]
    public partial class gerferiado
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDFERIADO { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime DATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 3, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
