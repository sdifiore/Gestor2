namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pinv_tpfecha")]
    public partial class pinv_tpfecha
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTPFECHA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(40)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string PERIODICIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSIDGRADE { get; set; }

        [StringLength(16777215)]
        public string FILT_FISC_E { get; set; }

        [StringLength(16777215)]
        public string FILT_FISC_S { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIV_FISC_PDVS { get; set; }

        [StringLength(16777215)]
        public string FILT_FISC_PDVS { get; set; }

        [StringLength(16777215)]
        public string FILT_FISC_OPE { get; set; }

        [StringLength(16777215)]
        public string FILT_FISC_OPS { get; set; }

        [StringLength(16777215)]
        public string FILT_FISC_TRANSF { get; set; }

        [StringLength(16777215)]
        public string FILT_FISC_MS { get; set; }

        [StringLength(16777215)]
        public string FILT_FISC_ME { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ALG_FISC_CUSTMED { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string APURA_FISC_TIPO { get; set; }

        public decimal? APURA_FISC_VENDPERC { get; set; }

        public decimal? APURA_FISC_PROCPERC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string APURA_FISC_ACABINTE { get; set; }

        [StringLength(16777215)]
        public string FILT_REAL_LOG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string HAB_DATAS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string HAB_EDIT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string TRAVA_FISC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string TRAVA_FISI { get; set; }

        [StringLength(16777215)]
        public string VARIAVEIS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCANUSU { get; set; }

        public DateTime? CNSCANMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSCANMOT { get; set; }
    }
}
