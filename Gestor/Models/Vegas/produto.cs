namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.produto")]
    public partial class produto
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string CODRESU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CODUNIVERS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODANP { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(45)]
        public string DESCRIPT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string DESCRESU { get; set; }

        [Column(TypeName = "char")]
        [StringLength(45)]
        public string COMPLEMENT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTIPO { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(15)]
        public string DEPARTAMEN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string FAMILIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string LINHA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CLASSIFICA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODCLCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string MARCA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO_E { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANO_S { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOLOCAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string LOCAL_DEF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string LOCALIZA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string CTRLOTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LOTEUNICO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MOVLOTEINTEGRAL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FANTASMA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PESOVARIAV { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PESOUNITAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BLOQALTDESCR { get; set; }

        public int VALIDADE { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string UNIDADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UN_ENTRADA { get; set; }

        public decimal FATOR_CONV { get; set; }

        public decimal PESO_BRUTO { get; set; }

        public decimal PESO_LIQUI { get; set; }

        public decimal DM_ALTURA { get; set; }

        public decimal DM_LARGURA { get; set; }

        public decimal DM_PROFUN { get; set; }

        public decimal CUSTO_MED { get; set; }

        public decimal CUSTO { get; set; }

        public decimal MARGEM { get; set; }

        public decimal PRECO { get; set; }

        public decimal VENDA { get; set; }

        public DateTime? ALTPRECO { get; set; }

        public decimal ULT_CUSTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ULT_DTENTR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string CODCLFISCAL { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ICMSST_CEST { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ICM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ISS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string IPI { get; set; }

        public decimal LOTEECON { get; set; }

        public decimal LOTEMULT { get; set; }

        public decimal PONTOPED { get; set; }

        public decimal ESTMINIMO { get; set; }

        public decimal ESTMAXIMO { get; set; }

        public decimal ESTSEGU { get; set; }

        public int RESUPRI { get; set; }

        public int TMPPED { get; set; }

        [StringLength(16777215)]
        public string OBS { get; set; }

        [StringLength(16777215)]
        public string OBS_AQUISICAO { get; set; }

        public int? MRP_NIVEL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BX_CONSUMO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BX_PROCESSO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ESTR_TPGRADE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ESTR_GRADEOBRIG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string ENG_TPGRADE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PUBLICA_DT { get; set; }

        public DateTime? PUBLICA_MOM { get; set; }

        public int? PUBLICA_RESP { get; set; }

        [StringLength(16777215)]
        public string PUBLICA_OBS { get; set; }

        [StringLength(16777215)]
        public string EXPRVARIACAO { get; set; }

        public decimal CONSMED { get; set; }

        public decimal CUSPED { get; set; }

        public decimal CUSOPT { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CNSSTATUS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSSTATUSU { get; set; }

        public DateTime? CNSSTATMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(32)]
        public string CNSHASHMD5 { get; set; }

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
