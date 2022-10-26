using Microsoft.EntityFrameworkCore;
using TopSegurosBrasil.Data;
using TopSegurosBrasil.Models;
using TopSegurosBrasil.Services.Exceptions;

namespace TopSegurosBrasil.Services
{
    public class ApoliceService
    {
        private readonly TopSegurosBrasilContext _context;

        public ApoliceService(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        public List<Apolice> FindAll()
        {
            return _context.Apolice.ToList();
        }

        public void Insert(Apolice obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Apolice FindById(int id)
        {
            return _context.Apolice.Include(obj => obj.PlanoDoSeguro).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Apolice.Find(id);
            _context.Apolice.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Apolice obj)
        {
            if (!_context.Apolice.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
