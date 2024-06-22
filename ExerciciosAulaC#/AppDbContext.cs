
using Microsoft.EntityFrameworkCore;

namespace ExerciciosAulaC_
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=exercicios.db");
        }
    }
}
