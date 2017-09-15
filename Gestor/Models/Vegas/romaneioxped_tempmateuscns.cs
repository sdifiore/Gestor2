namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.romaneioxped_tempmateuscns")]
    public partial class romaneioxped_tempmateuscns
    {
        [Key]
        public Guid UIDROMXPED { get; set; }

        public Guid? IDSAIDA { get; set; }

        public Guid? UUIDPEDIDO { get; set; }

        public decimal? IDPEDIDO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string DATA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public decimal? VALOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string FECHAMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string STATUS { get; set; }
    }
}
