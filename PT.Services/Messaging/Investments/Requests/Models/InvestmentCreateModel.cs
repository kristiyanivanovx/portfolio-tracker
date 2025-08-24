namespace PT.Services.Messaging.Investments.Requests.Models
{
	public class InvestmentCreateModel
	{
		public required string Name { get; set; }

		public required string AssetType { get; set; }

		public required string ActionType { get; set; }

		public int Amount { get; set; }

		public int PricePerUnit { get; set; }
	}
}
