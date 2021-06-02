using Ejemploproducto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemploproducto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Productos.db");
        }
    }
}
