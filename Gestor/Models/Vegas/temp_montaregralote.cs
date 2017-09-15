namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.temp_montaregralote")]
    public partial class temp_montaregralote
    {
        [Key]
        public int IDLAN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODREGRA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTPREGRA { get; set; }

        public decimal? ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVADA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(80)]
        public string NOMEPROC { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string VARIAVEIS { get; set; }
    }
}
