using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA_OOP.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Informe um CPF válido")]
        public string CPF { get; set; }
        public string CEP { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Convenio Convenio { get; set; }
        [Display(Name = "Convenio Cadastrado")]
        public int? ConvenioId { get; set; }
        public Procedimento Procedimento { get; set; }
        [Display(Name ="Procedimento")]
        public int? ProcedimentoCodigo { get; set; }

        public Paciente()
        {
        }

        public Paciente(int id, string nome, string rua, int numero, string bairro, string complemento, string cPF, string cEP, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Complemento = complemento;
            CPF = cPF;
            CEP = cEP;
            Email = email;
            Telefone = telefone;
        }
    }
}
