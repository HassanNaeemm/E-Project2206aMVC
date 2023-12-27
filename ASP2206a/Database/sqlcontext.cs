using ASP2206a.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP2206a.Database
{
    public class sqlcontext:DbContext
    {
        public sqlcontext(DbContextOptions<sqlcontext> option) : base(option)
        {

        }
        public DbSet<contactmodel> tblcontact { get; set; }
    }
}
