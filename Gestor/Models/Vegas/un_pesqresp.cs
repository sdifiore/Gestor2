namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.un_pesqresp")]
    public partial class un_pesqresp
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDRESPOSTA { get; set; }

        public Guid? IDPESQUISADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string IDPESQINFO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string MULT_ALTERNAT { get; set; }

        [StringLength(16777215)]
        public string RESPOSTA { get; set; }

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
