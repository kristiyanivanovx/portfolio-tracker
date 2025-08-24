namespace API
{
	public class Investment
	{
		public required string Name { get; set; }
		
		public required string AssetType { get; set; }

		public required string Type { get; set; }

		public int Amount { get; set; }

		public DateOnly Date { get; set; }

		public int PricePerUnit { get; set; }
	}
}
