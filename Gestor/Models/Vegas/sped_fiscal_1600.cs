namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.sped_fiscal_1600")]
    public partial class sped_fiscal_1600
    {
        [Key]
        [Column(Order = 0)]
        public Guid UIDREG { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPESSOA { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(6)]
        public string MODULO { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(40)]
        public string REDE { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
