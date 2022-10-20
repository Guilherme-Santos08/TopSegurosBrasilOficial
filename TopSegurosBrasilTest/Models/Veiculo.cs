using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopSegurosBrasil.Models
{
    public class Veiculo
    {
        [Key()]
        public int Id { get; set; }

		public string Chassi { get; set; }

		public string Cor { get; set; }

		public string Marca { get; set; }

		public string Modelo { get; set; }

		public string Placa { get; set; }

        [ForeignKey("Cliente")]
		public int ClienteId { get; set; }

        [ForeignKey("Apolice")]
        public int ApoliceId { get; set; }

		public Veiculo() { }

        public Veiculo(int id, string chassi, string cor, string marca, string modelo, string placa, int clienteId, int apoliceId)
        {
            Id = id;
            Chassi = chassi;
            Cor = cor;
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            ClienteId = clienteId;
            ApoliceId = apoliceId;
        }
    }
}
