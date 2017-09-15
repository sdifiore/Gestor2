namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.un_medconv")]
    public partial class un_medconv
    {
        [Key]
        public int IDCONVE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODUNIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONVDE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONVPARA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string FATOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
