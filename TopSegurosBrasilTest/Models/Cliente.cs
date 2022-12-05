using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TopSegurosBrasil.Models
{
    public class Cliente
    {
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [EmailAddress(ErrorMessage = "Coloque um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        public string Rg { get; set; }

        public char Genero { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [StringLength(8, MinimumLength = 5, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public int Num_Imovel { get; set; }


        public Cliente()
        {

        }

        public Cliente(
            int id, string nome, DateTime dataNascimento,
            string email, string celular,
            string cpf, string rg, char genero,
            string bairro, string cidade, string estado,
            int cep, int numImovel
            )
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            Celular = celular;
            Cpf = cpf;
            Rg = rg;
            Genero = genero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Num_Imovel = numImovel;
        }
    }
}
