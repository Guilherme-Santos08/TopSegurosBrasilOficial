using System.ComponentModel.DataAnnotations;

namespace TopSegurosBrasil.Models
{
    public class PlanoDoSeguro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Nome do Plano")]
        public string NomeDoPlano { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }


        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Anexo pdf")]
        public string AnexoPdf { get; set; }

        public PlanoDoSeguro() {}

        public PlanoDoSeguro(int id, string nomeDoPlano, double preco, string anexoPdf)
        {
            Id = id;
            NomeDoPlano = nomeDoPlano;
            Preco = preco;
            AnexoPdf = anexoPdf;
        }
    }
}
