using DataBaseStorage.entities;
using Microsoft.EntityFrameworkCore;

namespace DataBaseStorage
{
    public class context : DbContext
    {
        public DbSet<detail> details { get; set; }
        public DbSet<resultEntity> resultEntities { get; set; }
        public DbSet<unit> units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=bd_db;  Integrated Security=true;TrustServerCertificate=true");
        }

    }
}
