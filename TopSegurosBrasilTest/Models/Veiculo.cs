using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopSegurosBrasil.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

		public string Chassi { get; set; }

		public string Cor { get; set; }

        public Fabricante Fabricante { get; set; }
        [Required(ErrorMessage = "Fabricante precisa ser preenchido")]
        [Display(Name = "Fabricante")]
        public int FabricanteId { get; set; }

        public AnoDosModelo AnoDosModelo { get; set; }
        [Required(ErrorMessage = "Ano do Modelo precisa ser preenchido")]
        [Display(Name = "Ano do Modelo")]
        public int AnoDosModeloId { get; set; }

        public string Placa { get; set; }

        public string VersaoDoModelo { get; set; }

        public Cliente Cliente { get; set; }
		public int ClienteId { get; set; }

		public Veiculo() { }

        public Veiculo(int id, string chassi, string cor, Fabricante fabricante, AnoDosModelo anoDosModelo, string placa, string versaoDoModelo,int clienteId)
        {
            Id = id;
            Chassi = chassi;
            Cor = cor;
            Fabricante = fabricante;
            AnoDosModelo = anoDosModelo;
            Placa = placa;
            VersaoDoModelo = versaoDoModelo;
            ClienteId = clienteId;
        }
    }
}
