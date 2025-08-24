using PT.Services.Messaging.Investments.Requests.Models;

namespace PT.Services.Messaging.Investments.Requests
{
	public class CreateInvestmentRequest : ServiceRequestBase
	{
		public InvestmentCreateModel Investment { get; set; }

		public CreateInvestmentRequest(InvestmentCreateModel investment)
		{
			Investment = investment;
		}
	}
}
