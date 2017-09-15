namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_proclfiscal")]
    public partial class base_proclfiscal
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CODCLFISCAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(150)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(15)]
        public string CLFISCAL_COD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string EXTIPI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(8)]
        public string CAPITULONCM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODORIGEM { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODMATERIAL_E { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string CODMATERIAL_S { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMS_CNF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ICMS_ALIQRED { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMS_CALC { get; set; }

        public decimal ICMS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ICMS_RBASECOD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ICMS_ISENTONZERAREDU { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string ICMS_SUBSTRIB { get; set; }

        public int? ICMS_BASELEGAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMSST_CEST { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string IPI_CNF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string IPI_CST_ENTRADA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string IPI_CENQ_ENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string IPI_CST_SAIDA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        public string IPI_CENQ_SAI { get; set; }

        public decimal IPI_ALIQ { get; set; }

        public decimal IPI_RBASEVAL { get; set; }

        public int? IPI_BASELEGAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string PIS_CNF_E { get; set; }

        public decimal PIS_ALIQ_E { get; set; }

        public Guid? PIS_NATBCCRED_E { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string PIS_CNF { get; set; }

        public decimal PIS_ALIQ { get; set; }

        public decimal PIS_RBASEVAL { get; set; }

        public Guid? PIS_NATRECEITA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string COF_CNF_E { get; set; }

        public decimal COF_ALIQ_E { get; set; }

        public Guid? COF_NATBCCRED_E { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string COF_CNF { get; set; }

        public decimal COF_ALIQ { get; set; }

        public decimal COF_RBASEVAL { get; set; }

        public Guid? COF_NATRECEITA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ISS_CNF { get; set; }

        public decimal ISS_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string ISS_CODSERV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string ISS_CODTRIBMUN { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string II_CNF { get; set; }

        public decimal II_ALIQ { get; set; }

        public decimal CIDE_ALIQ { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string IPI_NCM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string IPI_APLIC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string SUPERIOR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CONSOLIDA { get; set; }

        public int? NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CNSPADRAO { get; set; }

        [StringLength(16777215)]
        public string CNSAJUDA { get; set; }

        [StringLength(16777215)]
        public string CNSSCRIPT { get; set; }

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
