using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SA_OOP.Models
{
    public class Procedimento
    {
        [Key]
        public int Codigo { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }


        [Display(Name = "Nome Procedimento")]
        [Required]
        [RegularExpression(@"^([a-zA-Z ]*?)*$", ErrorMessage = "Formato Inválido")]
        public string NomeProcedimento { get; set; }


        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(10,99999.99, ErrorMessage = "Valor procedimento deve estar entre {1} e {2}")]
        public double Valor { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z ]*?)*$", ErrorMessage = "Formato Inválido")]
        public string Genero { get; set; }


        [DisplayName("Exceção")]
        [RegularExpression(@"^([a-zA-Z ]*?)*$")]
        public string Excecao { get; set; }



        public Procedimento()
        {
        }

        public Procedimento(int codigo, DateTime data, string nomeProcedimento, double valor, string genero, string excecao)
        {
            Codigo = codigo;
            Data = data;
            NomeProcedimento = nomeProcedimento;
            Valor = valor;
            Genero = genero;
            Excecao = excecao;
        }
    }
}
