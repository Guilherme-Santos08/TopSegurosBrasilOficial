namespace TopSegurosBrasil.Models.ViewModels
{
    public class VeiculoFormViewModel
    {
        public Veiculo Veiculo { get; set; }
        public ICollection<Fabricante> Fabricantes { get; set; }
        public ICollection<AnoDosModelo> AnoDosModelos { get; set; }
    }
}
