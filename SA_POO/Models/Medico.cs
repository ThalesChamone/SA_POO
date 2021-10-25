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


        [Required]
        [RegularExpression(@"^([a-zA-Z ]*?)\s+([a-zA-Z]*)$", ErrorMessage = "Nome Inválido")]
        public string Nome { get; set; }


        [Required]
        public string Rua { get; set; }


        [Required]
        public int Numero { get; set; }


        [Required]
        public string Bairro { get; set; }


        public string Complemento { get; set; }

        
        public string CPF { get; set; }


        [Required]
        public string CEP { get; set; }


        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail não tem formato valido")]
        [Required]
        public string Email { get; set; }


        [Required]
        [RegularExpression(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$", ErrorMessage = "Formato inválido")]
        public string Telefone { get; set; }


        public Especialidade Especialidade { get; set; }


        [Display(Name = "Especialidade")]
        public int EspecialidadeId { get; set; }



        public Medico()
        {
        }

        public Medico(int id, string nome, string rua, int numero, string bairro, string complemento, string cPF, string cEP, string email, string telefone)
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