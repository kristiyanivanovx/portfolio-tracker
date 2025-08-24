using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PT.Services.Contracts;
using PT.Services.Messaging.Investments.Requests;
using PT.Services.Messaging.Investments.Requests.Models;
using PT.Services.Messaging.Investments.Responses;

namespace API.Controllers
{
	/// <summary>
	/// Investments controller.
	/// </summary>
	[ApiController]
	[Route("api/[controller]")]
	[Produces("application/json")]
	public class InvestmentsController : ControllerBase
	{
		private IInvestmentService _investmentService;

		public InvestmentsController(IInvestmentService investmentService)
		{
			_investmentService = investmentService;
		}

		/// <summary>
		/// Get all investments.
		/// </summary>
		/// <returns>Retrun list of all investments.</returns>
		[HttpGet]
		[ProducesResponseType(typeof(GetAllInvestmentsResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAllInvestments()
			=> Ok(await _investmentService.GetAllInvestmentsAsync(new()));

		/// <summary>
		/// Save an investment.
		/// </summary>
		/// <returns>Returns null if not successful.</returns>
		[HttpPost]
		[ProducesResponseType(typeof(CreateInvestmentResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> CreateInvestment([FromBody] InvestmentCreateModel model)
			=> Ok(await _investmentService.CreateInvestmentAsync(new(model)));

		/// <summary>
		/// Delete an investment.
		/// </summary>
		/// <returns>Return null if not successful.</returns>
		[HttpDelete("{id}")]
		[ProducesResponseType(typeof(DeleteInvestmentResponse), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> DeleteInvestment([FromRoute] int id)
			=> Ok(await _investmentService.DeleteInvestmentAsync(new DeleteInvestmentRequest { Id = id }));
	}
}
