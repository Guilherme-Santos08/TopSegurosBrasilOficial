using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopSegurosBrasil.Data;
using TopSegurosBrasil.Models;
using TopSegurosBrasil.Services.Exceptions;

namespace TopSegurosBrasil.Services
{
    public class ClientService
    {
        private readonly TopSegurosBrasilContext _context;

        public ClientService(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        public List<Client> FindAll()
        {
            return _context.Client.ToList();
        }

        public void Insert(Client obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Client FindById(int id)
        {
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return _context.Client.Include(obj => obj.TiposDeSeguro).FirstOrDefault(obj => obj.Id == id);
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public void Remove(int id)
        {
            var obj = _context.Client.Find(id);
            _context.Client.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Client obj)
        {
            if (!_context.Client.Any(x => x.Id == obj.Id))
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
