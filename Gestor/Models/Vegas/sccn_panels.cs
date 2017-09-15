namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sccn_panels")]
    public partial class sccn_panels
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPANEL { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(60)]
        public string NOME { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(80)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(40)]
        public string DESCRESU { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDEM { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
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
        [Column(Order = 6, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 7, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
