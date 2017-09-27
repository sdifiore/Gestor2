using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestor.Models
{
    public class Parametros
    {
        public int Id { get; set; }

        [Display(Name ="Data")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Display(Name ="Dólar")]
        public float Dolar { get; set; }

        [Display(Name = "Proporção Fios e Gaxetas")]
        public float PropFitasFioGaxeta { get; set; } // Proporção do custo dos sub-produtos de PTFE Puro destinados a Fios & Gaxetas que é assimilado pela linha de Fitas

        [Display(Name = "Proporção Sucatas Vendáveis")]
        public float PropSucatas { get; set; } // Proporção do custo das sucatas vendáveis de PTFE Puro que é assimilado pela linha de Fitas

        [Display(Name ="Proporção Grafitados")]
        public float PropGrafitado { get; set; } // Proporção do custo dos sub-produtos de PTFE Grafitado destinados a Fios & Gaxetas que é assimilado pela linha de Fitas Grafitadas
    }
}