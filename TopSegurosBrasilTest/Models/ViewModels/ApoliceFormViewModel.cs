namespace TopSegurosBrasil.Models.ViewModels
{
    public class ApoliceFormViewModel
    {
        public Apolice Apolice { get; set; }
        public ICollection<PlanoDoSeguro> PlanoDoSeguros { get; set; }
    }
}
