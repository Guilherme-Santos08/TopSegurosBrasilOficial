using TopSegurosBrasil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TopSegurosBrasil.Services.Exceptions;
using TopSegurosBrasil.Data;

namespace TopSegurosBrasil.Services
{
    public class VeiculoService
    {
        private readonly TopSegurosBrasilContext _context;

        public VeiculoService(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        public List<Veiculo> FindAll()
        {
            return _context.Veiculo.ToList();
        }

        public void Insert(Veiculo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Veiculo FindById(int id)
        {
            return _context.Veiculo.Include(obj => obj.AnoDosModelo).Include(obj => obj.Fabricante).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Veiculo.Find(id);
            _context.Veiculo.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Veiculo obj)
        {
            if (!_context.Veiculo.Any(x => x.Id == obj.Id))
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