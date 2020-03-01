using TaxaJuros.Domain;
using Microsoft.EntityFrameworkCore;

namespace TaxaJuros.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Taxa> Taxa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer("Server=BRUNOPC\\SQLEXPRESS;Database=taxajuros;Trusted_Connection=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
