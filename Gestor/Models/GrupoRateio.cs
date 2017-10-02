using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestor.Models
{
    public class GrupoRateio
    {
        public int GrupoRateioId { get; set; }

        [StringLength(50)]
        [Display(Name = "Grupo de Rateio")]
        public string Descricao { get; set; }
    }
}