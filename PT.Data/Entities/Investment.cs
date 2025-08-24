using System.ComponentModel.DataAnnotations;

namespace PT.Data.Entities
{
	public class Investment
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public required string Name { get; set; }

		[Required]
		public required string AssetType { get; set; }

		[Required]
		public required string ActionType { get; set; }

		[Required]
		public int Amount { get; set; }

		[Required]
		public DateOnly Date { get; set; }

		[Required]
		public int PricePerUnit { get; set; }
	}
}
