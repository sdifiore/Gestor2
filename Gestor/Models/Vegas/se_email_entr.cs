namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.se_email_entr")]
    public partial class se_email_entr
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDENTR { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(120)]
        public string EMAIL_FROM { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(120)]
        public string EMAIL_TO { get; set; }

        [StringLength(16777215)]
        public string EMAIL_CC { get; set; }

        [StringLength(16777215)]
        public string EMAIL_REPLY { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "char")]
        [StringLength(120)]
        public string EMAIL_SUBJECT { get; set; }

        [StringLength(16777215)]
        public string EMAIL_BODY { get; set; }

        [StringLength(16777215)]
        public string EMAIL_BODYHTML { get; set; }

        [StringLength(1073741823)]
        public string EMAIL_RAW { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "char")]
        [StringLength(120)]
        public string CONF_HOST { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "char")]
        [StringLength(120)]
        public string CONF_USER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string CONF_PSWD { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CONF_PORT { get; set; }

        public DateTime? MARCA_MOMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string MARCA_ORIGEMTAB { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string MARCA_ORIGEMID { get; set; }

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

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 8, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
