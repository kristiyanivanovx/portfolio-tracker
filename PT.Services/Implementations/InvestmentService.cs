using System.Collections.Generic;
using Azure;
using Microsoft.EntityFrameworkCore;
using PT.Data.Contexts;
using PT.Data.Entities;
using PT.Services.Contracts;
using PT.Services.Messaging;
using PT.Services.Messaging.Investments.Requests;
using PT.Services.Messaging.Investments.Responses;
using PT.Services.Messaging.Investments.Responses.Models;

namespace PT.Services.Implementations
{
	public class InvestmentService : IInvestmentService
	{
		private readonly PortfolioTrackerDbContext _context;

		public InvestmentService(PortfolioTrackerDbContext context)
		{
			_context = context;
		}

		public async Task<CreateInvestmentResponse> CreateInvestmentAsync(CreateInvestmentRequest request)
		{
			try
			{
				var investment = new Investment()
				{
					Name = request.Investment.Name,
					Amount = request.Investment.Amount,
					PricePerUnit = request.Investment.PricePerUnit,
					ActionType = request.Investment.ActionType,
					AssetType = request.Investment.AssetType
				};

				await _context.Investments.AddAsync(investment);
				await _context.SaveChangesAsync();

				return new(BusinessStatusCodeEnum.Success);
			}
			catch (Exception)
			{
				return new(BusinessStatusCodeEnum.InternalServerError);
			}
		}

		public async Task<GetAllInvestmentsResponse> GetAllInvestmentsAsync(GetAllInvestmentsRequest request)
		{
			GetAllInvestmentsResponse response = new();

			var investments = await _context.Investments.ToListAsync();
			
			foreach (var investment in investments) 
			{
				response.Investments.Add(new() 
				{
					Name = investment.Name,
					Amount = investment.Amount,
					PricePerUnit = investment.PricePerUnit,
					ActionType = investment.ActionType,
					AssetType = investment.AssetType
				});	
			}
			
			response.StatusCode = BusinessStatusCodeEnum.Success;
				
			return response;
		}

		public async Task<DeleteInvestmentResponse> DeleteInvestmentAsync(DeleteInvestmentRequest request)
		{
			var investment = await _context.Investments.SingleOrDefaultAsync(x => x.Id == request.Id);

			if (investment is null)
			{
				return new(BusinessStatusCodeEnum.MissingObject);
			}

			try
			{
				_context.Remove(investment);
				
				await _context.SaveChangesAsync();

				return new(BusinessStatusCodeEnum.Success);
			}
			catch (Exception)
			{
				return new(BusinessStatusCodeEnum.InternalServerError);
			}
		}
	}
}
