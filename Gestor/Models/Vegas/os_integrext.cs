namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.os_integrext")]
    public partial class os_integrext
    {
        [Key]
        public int IDINTEGREXT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ORIGEMTAB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string ORIGEMID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string VARIAVEL { get; set; }

        [StringLength(1073741823)]
        public string VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
