namespace PT.Services.Messaging.Investments.Responses
{
	public class CreateInvestmentResponse : ServiceResponseBase
	{
		public CreateInvestmentResponse(BusinessStatusCodeEnum statusCode)
			:base(statusCode)
		{
		}
	}
}
