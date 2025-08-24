using PT.Services.Messaging.Investments.Requests;
using PT.Services.Messaging.Investments.Responses;
namespace PT.Services.Contracts
{
	public interface IInvestmentService
	{
		/// <summary>
		/// Get list with all investments.
		/// </summary>
		/// <param name="request">Get all investments request object.</param>
		/// <returns>Return list with investments.</returns>
		Task<GetAllInvestmentsResponse> GetAllInvestmentsAsync(GetAllInvestmentsRequest request);

		/// <summary>
		/// Create an investment.
		/// </summary>
		/// <param name="request">Create investment request object.</param>
		/// <returns>Returns status code.</returns>
		Task<CreateInvestmentResponse> CreateInvestmentAsync(CreateInvestmentRequest request);

		/// <summary>
		/// Delete an investmnet.
		/// </summary>
		/// <param name="id">Delete investment request object.</param>
		/// <returns>Returns status code.</returns>
		Task<DeleteInvestmentResponse> DeleteInvestmentAsync(DeleteInvestmentRequest request);
	}
}
