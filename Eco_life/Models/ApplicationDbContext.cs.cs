using Microsoft.EntityFrameworkCore;
using Eco_life.Models;
using System.Collections.Generic;

namespace Eco_life.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
        {
        }
        public DbSet<Cadastros> Cadastro { get; set; }
        internal bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}
