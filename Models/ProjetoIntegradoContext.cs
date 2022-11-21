using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoIntegradoIV.Models
{
    public class ProjetoIntegradoContext : DbContext
    {
        public ProjetoIntegradoContext(DbContextOptions<ProjetoIntegradoContext> options) : base(options)
        {

        }

        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
    }
}