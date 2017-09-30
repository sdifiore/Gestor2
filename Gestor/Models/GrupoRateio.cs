using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestor.Models
{
    public class GrupoRateio
    {
        public int GrupoRateioId { get; set; }

        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}