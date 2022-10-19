using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TopSegurosBrasil.Models;

namespace TopSegurosBrasil.Data
{
    public class TopSegurosBrasilContext : DbContext
    {
        public TopSegurosBrasilContext(DbContextOptions<TopSegurosBrasilContext> options)
            : base(options)
        {
        }

        public DbSet<TopSegurosBrasil.Models.Client> Client { get; set; }
        public DbSet<TopSegurosBrasil.Models.TiposDeSeguro> TiposDeSeguro { get; set; }
    }
}
