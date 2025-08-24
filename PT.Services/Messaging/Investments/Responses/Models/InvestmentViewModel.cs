namespace PT.Services.Messaging.Investments.Responses.Models
{
	public class InvestmentViewModel
	{
		public required string Name { get; set; }

		public required string AssetType { get; set; }

		public required string ActionType { get; set; }

		public int Amount { get; set; }

		public int PricePerUnit { get; set; }

		public int TotalValue => this.Amount * this.PricePerUnit;
	}
}
