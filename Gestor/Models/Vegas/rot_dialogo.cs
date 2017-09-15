namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.rot_dialogo")]
    public partial class rot_dialogo
    {
        [Key]
        public Guid IDDIALOGO { get; set; }

        public int? RESPREMET { get; set; }

        [StringLength(16777215)]
        public string DESCRICAO { get; set; }

        public Guid? IDOCOR { get; set; }

        public Guid? IDPROV { get; set; }

        public Guid? OS { get; set; }

        public Guid? ATIVIDADE { get; set; }

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
