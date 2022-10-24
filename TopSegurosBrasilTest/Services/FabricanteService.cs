using TopSegurosBrasil.Data;
using TopSegurosBrasil.Models;

namespace TopSegurosBrasil.Services
{
    public class FabricanteService
    {
        private readonly TopSegurosBrasilContext _context;

        public FabricanteService(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        public List<Fabricante> FindAll()
        {
            return _context.Fabricante.OrderBy(x => x.NomeDoFabricante).ToList();
        }
    }
}
