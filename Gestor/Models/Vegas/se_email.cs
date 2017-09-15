namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.se_email")]
    public partial class se_email
    {
        [Key]
        [Column(Order = 0)]
        public Guid UUIDEMAIL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string SMTP_HOST { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string SMTP_USER { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string SMTP_PWD { get; set; }

        public int? SMTP_PORT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string EMAIL_FROM { get; set; }

        [StringLength(16777215)]
        public string EMAIL_TO { get; set; }

        [StringLength(16777215)]
        public string EMAIL_CC { get; set; }

        [StringLength(16777215)]
        public string EMAIL_CCO { get; set; }

        [StringLength(16777215)]
        public string EMAIL_REPLY { get; set; }

        [Column(TypeName = "char")]
        [StringLength(120)]
        public string EMAIL_TITLE { get; set; }

        [StringLength(16777215)]
        public string EMAIL_TEXT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string EMAIL_HTML { get; set; }

        [StringLength(16777215)]
        public string EMAIL_ATTACHED { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EMAIL_PRIORIDADE { get; set; }

        public int? ENV_LIMITE_TENTA { get; set; }

        public int? ENV_TENTATIVA { get; set; }

        public DateTime? ENV_LASTTENTATIVA { get; set; }

        public DateTime? ENV_MOMENTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }

        [Key]
        [Column("_UCRC_", Order = 3, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_UCRC_ { get; set; }
    }
}
