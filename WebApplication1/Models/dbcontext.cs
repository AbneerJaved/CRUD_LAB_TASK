using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class dbcontext : DbContext
    {

        public dbcontext(DbContextOptions<dbcontext> options) : base(options)
        {


        }
        public DbSet<Order> Orders { get; set; }
    
    }
}
