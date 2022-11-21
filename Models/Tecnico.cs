using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradoIV.Models
{
    public class Tecnico : Pessoa
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Apelido { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Anos de Experiência")]
        public int AnosExperiencia { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Tempo de Contrato")]
        public int tempoContrato { get; set; }

        public void calcularSalario(double salarioBase, int horasExtras)
        {
            Salario = salarioBase * horasExtras;
        }
    }
}