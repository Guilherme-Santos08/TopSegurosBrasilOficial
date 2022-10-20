using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopSegurosBrasil.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

/*        [Display(Name = "Tipo de Seguro")]
        public char TipoSeguro { get; set; }*/

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [EmailAddress(ErrorMessage = "Coloque um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Rg { get; set; }

/*        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "{0} o tamanho deve ser no máximo {1}")]
        [Display(Name = "Genero Masculino(M) - Femenino(N)")]*/
        public char Genero { get; set; }


        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        public int Num_Imovel { get; set; }


        public Veiculo Veiculo { get; set; }
        public int VeiculoId { get; set; }


        public Cliente()
        {

        }

        public Cliente(
            int id, string nome, DateTime dataNascimento,
            string email, string celular,
            string cpf, string rg, char genero,
            string bairro, string cidade, string estado,
            int cep, int numImovel,
            int veiculoId
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
            VeiculoId = veiculoId;
        }
    }
}
