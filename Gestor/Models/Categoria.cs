using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestor.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [StringLength(2)]
        public string Apelido { get; set; }

        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}