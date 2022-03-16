using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.Services
{
    public class SiteDBContext:DbContext
    {
        public SiteDBContext(DbContextOptions<SiteDBContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
