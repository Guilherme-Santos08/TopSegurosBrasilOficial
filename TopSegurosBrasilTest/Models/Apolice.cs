using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopSegurosBrasil.Models
{
    public class Apolice
    {
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Inicio do Contrato")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataInicioContrato { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Vencimento do Contrato")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataVencimento { get; set; }

        [ForeignKey("Veiculo")]
        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Veiculo Id")]
        public int VeiculoId { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Seguro Escolhido")]
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
