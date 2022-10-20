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
        public DbSet<TopSegurosBrasil.Models.Apolice> Apolice { get; set; }
        public DbSet<TopSegurosBrasil.Models.Sinistro> Sinistro { get; set; }
        public DbSet<TopSegurosBrasil.Models.Veiculo> Veiculo { get; set; }
        public DbSet<TopSegurosBrasil.Models.Prestador> Prestador { get; set; }

    }
}
