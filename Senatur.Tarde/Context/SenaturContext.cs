using Microsoft.EntityFrameworkCore;
using Senatur.Tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senatur.Tarde.Context
{
    public class SenaturContext : DbContext
    {
        public DbSet<PacoteDomain> Pacote { get; set; }
        public DbSet<UsuarioDomain> Usuarios{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=Senatur__Tarde;user id= sa;password=132;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
