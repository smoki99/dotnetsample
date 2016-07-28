using Microsoft.EntityFrameworkCore;

namespace herokumxnet.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            System.Console.WriteLine("Configuration "+options.ToString());
            
        }

        public DbSet<Student> Students { get; set; }
    }

}
