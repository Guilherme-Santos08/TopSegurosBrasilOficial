namespace TopSegurosBrasil.Models
{
    public class AnoDosModelo
    {
        public int Id { get; set; }
        public DateTime AnoModelo { get; set; }

        public AnoDosModelo() { }

        public AnoDosModelo(int id, DateTime anoModelo)
        {
            Id = id;
            AnoModelo = anoModelo;
        }
    }
}
