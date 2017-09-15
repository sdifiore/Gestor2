namespace Gestor.Models.Vegas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vegas.tg_tarefa")]
    public partial class tg_tarefa
    {
        [Key]
        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODTAREFA { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(60)]
        public string DESCRICAO { get; set; }

        public int ORDEM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string TAREFAPAI { get; set; }

        [Column(TypeName = "char")]
        [StringLength(9)]
        public string CODCATEGORIA { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string ATIVADO { get; set; }

        public DateTime? CANCELADO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(60)]
        public string PROCESSO { get; set; }

        public int FREQQTD { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string FREQUNID { get; set; }

        public TimeSpan? TEMPOINI { get; set; }

        public TimeSpan? TEMPOFIN { get; set; }

        public long MAXESPERAINI { get; set; }

        public long MAXESPERAEXEC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAINI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATAFIN { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string NLOGAREXECOK { get; set; }

        public long ERRTENTATIVAS { get; set; }

        public long ERRTENTTEMPO { get; set; }

        public long ERRREPROG { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIA1 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIA2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIA3 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIA4 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIA5 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIA6 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string DIA7 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES1 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES2 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES3 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES4 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES5 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES6 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES7 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES8 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES9 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES10 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES11 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string MES12 { get; set; }

        public DateTime? EXECUTANDO { get; set; }

        public DateTime? ULTMOMEXEC { get; set; }

        public DateTime? ULTMOMEXECOK { get; set; }

        [StringLength(16777215)]
        public string ULTSTATUS { get; set; }

        public DateTime? PROXMOMEXEC { get; set; }

        public long NUMEXEC { get; set; }

        public long NUMEXECOK { get; set; }

        public long CONTATENTATIVAS { get; set; }

        public long REPROGS { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string FORCAEXEC { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSCADUSU { get; set; }

        public DateTime? CNSCADMOM { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string CNSALTUSU { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime CNSALTMOM { get; set; }
    }
}
