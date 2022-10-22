namespace TopSegurosBrasil.Models
{
    public class PlanoDoSeguro
    {
        public int Id { get; set; }
        public string NomeDoPlano { get; set; }
        public double Preco { get; set; }
        public string AnexoPdf { get; set; }

        public PlanoDoSeguro() {}

        public PlanoDoSeguro(int id, string nomeDoPlano, double preco, string anexoPdf)
        {
            Id = id;
            NomeDoPlano = nomeDoPlano;
            Preco = preco;
            AnexoPdf = anexoPdf;
        }
    }
}
