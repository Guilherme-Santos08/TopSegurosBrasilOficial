using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopSegurosBrasil.Models
{
    public class TiposDeSeguro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} precisa ser preenchido")]
        [Display(Name = "Descrição do Tipo de Seguro")]
        public string DescTipoDeSeguro { get; set; }

        public TiposDeSeguro() { }

        public TiposDeSeguro(int id, string name, string descTipoDeSeguro)
        {
            Id = id;
            Name = name;
            DescTipoDeSeguro = descTipoDeSeguro;
        }
    }
}
