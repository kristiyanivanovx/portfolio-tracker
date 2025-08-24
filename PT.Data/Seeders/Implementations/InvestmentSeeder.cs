using PT.Data.Entities;
using PT.Data.Seeders.Contracts;

namespace PT.Data.Seeders.Implementations
{
	internal class InvestmentSeeder : ISeeder<Investment>
	{
		public InvestmentSeeder()
		{
			IdCounter = -1;
		}

		private int IdCounter { get; set; }

		public IEnumerable<Investment> Seed()
		{
			return [
				new Investment()
				{
					Id = IdCounter--,
					Name = "Bitcoin",
					AssetType = "Crypto",
					ActionType = "Buy",
					Amount = 2,
					PricePerUnit = 323232,
					Date = DateOnly.FromDateTime(DateTime.UtcNow),
				},
				new Investment()
				{
					Id = IdCounter--,
					Name = "Ethereum",
					AssetType = "Crypto",
					ActionType = "Buy",
					Amount = 4,
					PricePerUnit = 4231,
					Date = DateOnly.FromDateTime(DateTime.UtcNow),
				},
				new Investment()
				{
					Id = IdCounter--,
					Name = "Tesla Inc.",
					AssetType = "Stock",
					ActionType = "Buy",
					Amount = 2,
					PricePerUnit = 340,
					Date = DateOnly.FromDateTime(DateTime.UtcNow),
				},
				new Investment()
				{
					Id = IdCounter--,
					Name = "Gold",
					AssetType = "Metal",
					ActionType = "Buy",
					Amount = 10,
					PricePerUnit = 3372,
					Date = DateOnly.FromDateTime(DateTime.UtcNow),
				},
				new Investment()
				{
					Id = IdCounter--,
					Name = "Silver",
					AssetType = "Metal",
					ActionType = "Buy",
					Amount = 1,
					PricePerUnit = 150,
					Date = DateOnly.FromDateTime(DateTime.UtcNow),
				},
				new Investment()
				{
					Id = IdCounter--,
					Name = "Microsoft",
					AssetType = "Stock",
					ActionType = "Buy",
					Amount = 5,
					PricePerUnit = 500,
					Date = DateOnly.FromDateTime(DateTime.UtcNow),
				},
				new Investment()
				{
					Id = IdCounter--,
					Name = "IBM",
					AssetType = "Stock",
					ActionType = "Buy",
					Amount = 6,
					PricePerUnit = 240,
					Date = DateOnly.FromDateTime(DateTime.UtcNow),
				},
				new Investment()
				{
					Id = IdCounter--,
					Name = "NVDA",
					AssetType = "Stock",
					ActionType = "Buy",
					Amount = 10,
					PricePerUnit = 3450,
					Date = DateOnly.FromDateTime(DateTime.UtcNow),
				}
			];
		}
	}
}
