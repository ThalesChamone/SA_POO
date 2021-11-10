using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA_OOP.Models
{
    public class Convenio
    {

        public int Id { get; set; }


        [Display(Name = "Nome Fantasia")]
        [Required]
        public string NomeFantasia { get; set; }


        [Required]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "CNPJ Inválido")]
        public string CNPJ { get; set; }


        [Display(Name = "Nome Empresa")]
        [Required]
        [RegularExpression(@"^([a-zA-Z ]*?)*$", ErrorMessage = "Formato Inválido")]
        public string NomeEmpresa { get; set; }


        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail não tem formato valido")]
        [Required]
        public string Email { get; set; }


        [Display(Name = "Nome Contato")]
        [Required]
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Nome inválido")]
        public string NomeContato { get; set; }


        [Display(Name = "Home Page")]
        [DataType(DataType.Url)]
        public string HomePage { get; set; }


        [Required]
        [RegularExpression(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$", ErrorMessage = "Formato inválido")]
        public string Telefone { get; set; }



        public Convenio()
        {
        }

        public Convenio(int id, string nomeFantasia, string cNPJ, string nomeEmpresa, string email, string nomeContato, string homePage, string telefone)
        {
            Id = id;
            NomeFantasia = nomeFantasia;
            CNPJ = cNPJ;
            NomeEmpresa = nomeEmpresa;
            Email = email;
            NomeContato = nomeContato;
            HomePage = homePage;
            Telefone = telefone;
        }
    }
}