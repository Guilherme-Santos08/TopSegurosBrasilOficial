using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopSegurosBrasil.Models
{
    public class Sinistro
    {
        [Key()]
        public int Id { get; set; }
        public string DataSinistro { get; set; }
        public string DescSinistro { get; set; }
        [ForeignKey("Veiculo")]
        public int VeiculoId { get; set; }

        public Sinistro() { }

        public Sinistro(int id, string dataSinistro, string descSinistro, int veiculoId)
        {
            Id = id;
            DataSinistro = dataSinistro;
            DescSinistro = descSinistro;
            VeiculoId = veiculoId;
        }
    }
}
