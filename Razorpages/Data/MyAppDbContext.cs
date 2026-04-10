using Microsoft.EntityFrameworkCore;
using Razorpages.Models;

namespace Razorpages.Data
{
    public class MyAppDbContext:DbContext
    {
        public MyAppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
    }
}
