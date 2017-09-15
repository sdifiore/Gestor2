namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.pronutri")]
    public partial class pronutri
    {
        [Key]
        public int IDNUTRI { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(14)]
        public string CODPRODUTO { get; set; }

        public int IDPESOVAR { get; set; }

        [Column(TypeName = "char")]
        [StringLength(35)]
        public string PORCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string UN_PORCAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string CALOR_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string CALOR_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string CARBO_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string CARBO_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string PROTE_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string PROTE_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string GORDU_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string GORDU_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string GORDUSAT_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string GORDUSAT_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string GORDTRANS_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string GORDTRANS_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string COLEST_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string COLEST_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string FIBRA_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string FIBRA_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string CALCIO_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string CALCIO_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string FERRO_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string FERRO_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string SODIO_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string SODIO_VD { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string ENERGETICO_VL { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string ENERGETICO_VD { get; set; }

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
