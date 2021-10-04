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
        [Display(Name ="Nome Fantasia")]
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        [Display(Name = "Nome Empresa")]
        public string NomeEmpresa { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Nome Contato")]
        public string NomeContato { get; set; }
        [Display(Name = "Home Page")]
        public string HomePage { get; set; }
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
