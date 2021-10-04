using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA_OOP.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Especialidade Especialidade { get; set; }
        [Display(Name = "Especialidade")]
        public int EspecialidadeId { get; set; }

        public Medico()
        {
        }

        public Medico(int id, string nome, string rua, int numero, string bairro, string complemento, string cEP, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Complemento = complemento;
            CEP = cEP;
            Email = email;
            Telefone = telefone;
        }
    }
}
