using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=Human;user=root;password=D0pe@fuck");
        }

        public DbSet<Human> Human { get; set; }
    }
}
