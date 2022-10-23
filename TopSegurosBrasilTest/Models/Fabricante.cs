using System.ComponentModel.DataAnnotations;

namespace TopSegurosBrasil.Models
{
    public class Fabricante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Nome do Fabricante")]
        public string NomeDoFabricante { get; set; }

        public Fabricante() { }

        public Fabricante(int id, string nomeDoFabricante)
        {
            Id = id;
            NomeDoFabricante = nomeDoFabricante;
        }
    }
}
