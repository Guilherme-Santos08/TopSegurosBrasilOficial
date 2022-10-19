using System.Collections.Generic;

namespace TopSegurosBrasil.Models.ViewModels
{
    public class ClientFormViewModel
    {
        public Client Client { get; set; }
        public Veiculo Veiculo { get; set; }
        public ICollection<TiposDeSeguro> TiposDeSeguros { get; set; }
    }
}
