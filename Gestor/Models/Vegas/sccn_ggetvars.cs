namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sccn_ggetvars")]
    public partial class sccn_ggetvars
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDGGETVAR { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(40)]
        public string VARNOME { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(60)]
        public string VARTITULO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(120)]
        public string VARDESC { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid IDGADGET { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string USUALTERA { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "char")]
        [StringLength(1)]
        public string VARTIPO { get; set; }

        [StringLength(16777215)]
        public string VARVALOR { get; set; }

        [StringLength(16777215)]
        public string SCRIPT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NATUALIZAR { get; set; }

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

        [Key]
        [Column("_UCRC_", Order = 8, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
