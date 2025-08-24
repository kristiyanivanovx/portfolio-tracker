using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PT.Data.Contexts;

namespace PT.Data
{
	public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PortfolioTrackerDbContext>
	{
		public PortfolioTrackerDbContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", false, true)
				.Build();

			var builder = new DbContextOptionsBuilder<PortfolioTrackerDbContext>();
			var connectionString = configuration.GetConnectionString("DefaultConnectionString");
			builder.UseSqlServer(connectionString);

			return new PortfolioTrackerDbContext(builder.Options);
		}
	}
}
