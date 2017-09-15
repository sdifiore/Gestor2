namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.base_crecnfbaixa")]
    public partial class base_crecnfbaixa
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODCNFBAIXA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string DESCRICAO { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string EMPRESA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string SINALIZACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CONVENIO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TIPOBAIXA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string PLANOCONTA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(14)]
        public string CENTROCUSTO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string RATEAR { get; set; }

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
