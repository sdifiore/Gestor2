using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestor.Models
{
    public class Unidade
    {
        public int UnidadeId { get; set; }

        [StringLength(2)]
        public string Apelido { get; set; }

        [StringLength(16)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}