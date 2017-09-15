namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.un_pesqestru")]
    public partial class un_pesqestru
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDPESQESTRU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string IDPESQINFO { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(20)]
        public string CODIGO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(16777215)]
        public string CNSAJUDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
