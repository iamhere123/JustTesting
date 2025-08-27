using Microsoft.EntityFrameworkCore;

namespace JustTesting.Data
{
    public class DContext : DbContext

    {
        public DContext(DbContextOptions<DContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().HasData(
                new Students { Id = 1, Name = "Alice", Age = 20, Grade = "A" },
                new Students { Id = 2, Name = "Bob", Age = 22, Grade = "B" },
                new Students { Id = 3, Name = "Charlie", Age = 21, Grade = "C" }
            );
        }

        public DbSet<Students> Students { get; set; }
    }
}
