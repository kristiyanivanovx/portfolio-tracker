using PT.Services.Messaging.Investments.Responses.Models;

namespace PT.Services.Messaging.Investments.Responses
{
	public class GetAllInvestmentsResponse : ServiceResponseBase
	{
		public List<InvestmentViewModel> Investments { get; set; } = new();
	}
}
