namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.gedfluxopub")]
    public partial class gedfluxopub
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDFLUXOPUB { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDARQUIVO { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(9)]
        public string IDATIVIDADE { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDEM { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RESPONSA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string DEPARTAMEN { get; set; }

        public DateTime? LIBERAMOM { get; set; }

        public int? LIBERARESP { get; set; }

        public Guid? SUPERIOR { get; set; }

        public DateTime? OKMOM { get; set; }

        public int? OKRESP { get; set; }

        [StringLength(16777215)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Key]
        [Column("_UCRC_", Order = 6, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
