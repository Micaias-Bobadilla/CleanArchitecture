using CA_EnterpiseLayer;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapters_Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
                
        }
        public DbSet<Beer> Beers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>().ToTable("BEER");
        }
            
    }
}
