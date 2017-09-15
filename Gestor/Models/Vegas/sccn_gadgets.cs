namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sccn_gadgets")]
    public partial class sccn_gadgets
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDGADGET { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(40)]
        public string NOME { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(40)]
        public string DESCRESU { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(60)]
        public string CATEGORIA { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDEM { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "char")]
        [StringLength(40)]
        public string PROCESSO { get; set; }

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
