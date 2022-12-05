using System.ComponentModel.DataAnnotations;

namespace TopSegurosBrasil.Models
{
    public class Prestador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Nome da Empresa")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Tipo do Prestador")]
        public string TipoPrestador { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [EmailAddress(ErrorMessage = "Coloque um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "CEP")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Número do Imóvel")]
        public int Num_Imovel { get; set; }

        public Prestador() { }

        public Prestador(int id, string nomeEmpresa, string cnpj, string tipoPrestador, string email, string telefone, string bairro, string cidade, string estado, int cep, int num_Imovel)
        {
            Id = id;
            NomeEmpresa = nomeEmpresa;
            Cnpj = cnpj;
            TipoPrestador = tipoPrestador;
            Email = email;
            Telefone = telefone;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Num_Imovel = num_Imovel;
        }
    }
}
