using System.ComponentModel.DataAnnotations;

namespace TopSegurosBrasil.Models
{
    public class AnoDosModelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Ano do Modelo")]
        public string AnoModelo { get; set; }

        public AnoDosModelo() { }

        public AnoDosModelo(int id, string anoModelo)
        {
            Id = id;
            AnoModelo = anoModelo;
        }
    }
}
