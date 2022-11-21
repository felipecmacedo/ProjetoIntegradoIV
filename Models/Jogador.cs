using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradoIV.Models
{
    public class Jogador : Pessoa
    {
        [Required(ErrorMessage = "Este campo � obrigat�rio")]
        [DisplayName("Nome da Camisa")]
        public string NomeCamisa { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo � obrigat�rio")]
        [DisplayName("Posi��o que joga")]
        public string posicaoJoga { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo � obrigat�rio")]
        [DisplayName("N�meros de Gols na Carreira")]
        public int numGolCarreira { get; set; }

        public void calcularSalario(double salarioBase, double bonus)
        {
            Salario = salarioBase + bonus;
        }
    }
}