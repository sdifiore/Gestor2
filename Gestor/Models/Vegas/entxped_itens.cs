namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.entxped_itens")]
    public partial class entxped_itens
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDITEMEXP { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ITEMPED { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ITEMENTRADA { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(14)]
        public string PRODUTO { get; set; }

        public decimal? QTD { get; set; }

        public DateTime? MOMENTO { get; set; }

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
