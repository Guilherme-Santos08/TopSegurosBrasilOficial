using TopSegurosBrasil.Data;
using TopSegurosBrasil.Models;

namespace TopSegurosBrasil.Services
{
    public class PlanoDoSeguroService
    {
        private readonly TopSegurosBrasilContext _context;

        public PlanoDoSeguroService(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        public List<PlanoDoSeguro> FindAll()
        {
            return _context.PlanoDoSeguro.OrderBy(x => x.NomeDoPlano).ToList();
        }
    }
}
