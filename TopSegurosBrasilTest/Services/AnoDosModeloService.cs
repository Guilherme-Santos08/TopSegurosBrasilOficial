using TopSegurosBrasil.Data;
using TopSegurosBrasil.Models;

namespace TopSegurosBrasil.Services
{
    public class AnoDosModeloService
    {
        private readonly TopSegurosBrasilContext _context;

        public AnoDosModeloService(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        public List<AnoDosModelo> FindAll()
        {
            return _context.AnoDoModelo.OrderBy(x => x.AnoModelo).ToList();
        }
    }
}
