using System;
using System.Collections.Generic;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;
using NEFGLibrary.CompanyData;

namespace NEFGLibrary.Investment
{
  public class Projection : IProjection
  {
    public DateTime ProjectInceptionDate { get; set; }
    public int ProjectionTerm { get; set; }
    public DateTime ProjectionMaturityDate { get; set; }

    public List<ErrorResponse> CheckValidation()
    {
      return new List<ErrorResponse>();
    }

        public decimal CalculateInvestmentPortfolioGrowthAverage(Growth growthDataId, MorningStar ms, IInvestment investment)
        {
            decimal result = 0m;

            int growthId = 0;
            switch (growthDataId)
            {
                case Growth.Low:growthId = 1;
                    break;
                case Growth.Target:growthId = 2;
                    break;
                case Growth.High:growthId = 3;
                    break;
                
            }

            decimal growthTableValue = 0m;
            decimal contributionValue = 0m;
            decimal subResult = 0m;

            foreach (PortfolioInvestmentAllocation PortfolioAllocatoin in investment.InvestmentPortfolios)
            {
                growthTableValue = MorningStar.GetSpecificGrowthDataValue(PortfolioAllocatoin.InvestmentPortfolio.PortfolioId, growthId, ms);
                contributionValue = PortfolioAllocatoin.ContributionPercentage;
                subResult = growthTableValue * contributionValue;
                result += subResult;
            }


            return result;
        }

        

    }
}