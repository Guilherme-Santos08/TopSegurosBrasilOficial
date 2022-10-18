using System.Collections.Generic;
using System.Linq;
using TopSegurosBrasil.Data;
using TopSegurosBrasil.Models;

namespace TopSegurosBrasil.Services
{
    public class TiposDeSeguroService
    {
        private readonly TopSegurosBrasilContext _context;

        public TiposDeSeguroService(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        public List<TiposDeSeguro> FindAll()
        {
            return _context.TiposDeSeguro.OrderBy(x => x.Name).ToList();
        }
    }
}
