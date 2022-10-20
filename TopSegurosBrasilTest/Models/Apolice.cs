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

        public double ValorApolice { get; set; }

        public string DescApolice { get; set; }

        [ForeignKey("Veiculo")]
        public int VeiculoId { get; set; }
        
        public Apolice() { }

        public Apolice(int id, DateTime dataInicioContrato, DateTime dataVencimento, double valorApolice, string descApolice, int veiculoId)
        {
            Id = id;
            DataInicioContrato = dataInicioContrato;
            DataVencimento = dataVencimento;
            ValorApolice = valorApolice;
            DescApolice = descApolice;
            VeiculoId = veiculoId;
        }
    }

}
