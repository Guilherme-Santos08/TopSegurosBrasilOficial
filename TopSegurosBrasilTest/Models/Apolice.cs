using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopSegurosBrasil.Models
{
    public class Apolice
    {
        [Key()]
        public int Id { get; set; }

        public DateTime DataInicioContrato { get; set; }

        public DateTime DataVencimento { get; set; }

        [ForeignKey("Veiculo")]
        public int VeiculoId { get; set; }

        public PlanoDoSeguro PlanoDoSeguro { get; set; }
        public int PlanoDoSeguroId { get; set; }

        public Apolice() { }

        public Apolice(int id, DateTime dataInicioContrato, DateTime dataVencimento, PlanoDoSeguro planoDoSeguro, int veiculoId)
        {
            Id = id;
            DataInicioContrato = dataInicioContrato;
            DataVencimento = dataVencimento;
            PlanoDoSeguro = planoDoSeguro;
            VeiculoId = veiculoId;
        }
    }

}
