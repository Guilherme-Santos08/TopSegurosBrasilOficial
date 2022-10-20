using System.ComponentModel.DataAnnotations;

namespace TopSegurosBrasil.Models
{
    public class Prestador
    {
        [Key()]
        public string Id { get; set; }

        public string NomeEmpresa { get; set; }
        public string Cnpj { get; set; }
        public string TipoPrestador { get; set; }

        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
        public int Num_Imovel { get; set; }

        public Prestador() { }

        public Prestador(string id, string nomeEmpresa, string cnpj, string tipoPrestador, string email, string telefone, string bairro, string cidade, string estado, int cep, int num_Imovel)
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
