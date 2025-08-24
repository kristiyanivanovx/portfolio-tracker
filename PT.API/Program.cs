using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PT.Data.Contexts;
using PT.Services.Contracts;
using PT.Services.Implementations;

namespace API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

			var builder = WebApplication.CreateBuilder(args);

			// I know this is bad (coupling the database / data access layer with the web api)
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");
			builder.Services.AddDbContext<PortfolioTrackerDbContext>(options =>
				options.UseSqlServer(connectionString, b => b.MigrationsAssembly("PT.Data")));

			builder.Services.AddCors(options =>
			{
				options.AddPolicy(
					name: MyAllowSpecificOrigins,
					policy =>
					{
						policy.WithOrigins("http://localhost:3000")
						  .AllowAnyHeader()
						  .AllowAnyMethod();
					});
			});

			string assemblyName = Assembly.GetExecutingAssembly().GetName().Name ?? "Wrong assembly name";

			builder.Services.AddControllers();

			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen(options =>
			{
				var xmlFilename = $"{assemblyName}.xml";
				options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
			});

			builder.Services.AddTransient<IInvestmentService, InvestmentService>();

			var app = builder.Build();

			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			// Configure the HTTP request pipeline.
			//app.UseHttpsRedirection();

			app.UseCors(MyAllowSpecificOrigins);

			app.MapControllers();

			app.Run();
		}
	}
}
