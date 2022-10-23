namespace TopSegurosBrasil.Models
{
    public class AnoDosModelo
    {
        public int Id { get; set; }
        public string AnoModelo { get; set; }

        public AnoDosModelo() { }

        public AnoDosModelo(int id, string anoModelo)
        {
            Id = id;
            AnoModelo = anoModelo;
        }
    }
}
