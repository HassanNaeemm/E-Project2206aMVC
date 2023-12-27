using ASP2206a.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP2206a.Context
{
	public class sqlcontext:DbContext
	{
		public sqlcontext(DbContextOptions<sqlcontext> option) : base(option)
		{

		}
		public DbSet<ImageModel> tblusers { get; set; }

	}
}
