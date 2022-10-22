namespace TopSegurosBrasil.Models
{
    public class Fabricante
    {
        public int Id { get; set; }
        public string NomeDoFabricante { get; set; }

        public Fabricante() { }

        public Fabricante(int id, string nomeDoFabricante)
        {
            Id = id;
            NomeDoFabricante = nomeDoFabricante;
        }
    }
}
