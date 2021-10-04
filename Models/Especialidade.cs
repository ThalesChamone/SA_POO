using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA_OOP.Models
{
    public class Especialidade
    {
        public int Id { get; set; }
        [Display(Name ="Especialidade Médica")]
        public string NomeEspecialidade { get; set; }

        public Especialidade()
        {
        }

        public Especialidade(int id, string nomeEspecialidade)
        {
            Id = id;
            NomeEspecialidade = nomeEspecialidade;
        }
    }
}
