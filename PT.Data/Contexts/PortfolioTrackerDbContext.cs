using Microsoft.EntityFrameworkCore;
using PT.Data.Entities;
using PT.Data.Seeders.Implementations;

namespace PT.Data.Contexts
{
	public class PortfolioTrackerDbContext : DbContext
	{
		public DbSet<Investment> Investments { get; set; }

		public PortfolioTrackerDbContext() { }

		public PortfolioTrackerDbContext(DbContextOptions<PortfolioTrackerDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Investment>().HasData(new InvestmentSeeder().Seed());
		}
	}
}
