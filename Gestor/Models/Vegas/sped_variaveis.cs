namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sped_variaveis")]
    public partial class sped_variaveis
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDVAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOSPED { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string AGRUPA_COD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string AGRUPA_DESC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string VAR_COD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string VAR_DESC { get; set; }

        [StringLength(16777215)]
        public string VAR_VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 2, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
