using Microsoft.EntityFrameworkCore;

namespace JustTesting.Data
{
    public class DContext : DbContext

    {
        public DContext(DbContextOptions<DContext> options) : base(options)
        {
        }
        

    }
}
