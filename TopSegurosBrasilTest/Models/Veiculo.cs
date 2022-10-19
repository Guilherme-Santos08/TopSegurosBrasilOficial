using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopSegurosBrasil.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime AnoModelo { get; set; }

        public string Chassi { get; set; }
        public int LimitePassageiro { get; set; }
        public string Cor { get; set; }

        public Client Client { get; set; }
        public int ClientId { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(
            int id, string placa, string modelo, DateTime anoModelo,
            string chassi, int limitePassageiro, string cor
            )
        {
            Id = id;
            Placa = placa;
            Modelo = modelo;
            AnoModelo = anoModelo;
            Chassi = chassi;
            LimitePassageiro = limitePassageiro;
            Cor = cor;
        }
    }
}