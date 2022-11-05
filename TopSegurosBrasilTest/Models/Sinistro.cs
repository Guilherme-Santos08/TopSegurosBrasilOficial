using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopSegurosBrasil.Models
{
    public class Sinistro
    {
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Data do Sinistro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string DataSinistro { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Descrição do Sinistro")]
        public string DescSinistro { get; set; }


        [ForeignKey("Veiculo")]
        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Id do Veiculo")]
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
