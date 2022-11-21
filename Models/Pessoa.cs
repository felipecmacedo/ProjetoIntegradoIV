using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradoIV.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo � obrigat�rio")]
        [DisplayName("Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Este campo � obrigat�rio")]
        [DisplayName("Ano de Nascimento")]
        public int AnoNasc { get; set; }

        [Required(ErrorMessage = "Este campo � obrigat�rio")]
        [DisplayName("Idade")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Este campo � obrigat�rio")]
        [DisplayName("Altura")]
        public double Altura { get; set; }

        [Required(ErrorMessage = "Este campo � obrigat�rio")]
        [DisplayName("Peso")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Salario")]
        public double Salario { get; set; }

        public void calcularIdade(int anoAtual)
        {
            Idade = anoAtual - AnoNasc;
        }
    }
}