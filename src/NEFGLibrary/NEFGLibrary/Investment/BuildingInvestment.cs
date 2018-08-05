using NEFGLibrary.Investment.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NEFGLibrary
{
    public class BuildingInvestment : IInvestment
    {
        public InvestmentTypes InvestmentType { get; set; }
        
        public decimal InvestmentAmount { get; set; }
        public decimal InvestmentAmountAfterInitialFinancialAdviserFee { get; set; }
        public decimal EscalationRatePerAnnum { get; set; }
        public List<PortfolioInvestmentAllocation> InvestmentPortfolios { get; set; }

        public void AddPortfolioAllocation(PortfolioInvestmentAllocation portfolioInvestmentAllocation)
        {
            if (InvestmentPortfolios == null)
            {
                InvestmentPortfolios = new List<PortfolioInvestmentAllocation>();
            }
            InvestmentPortfolios.Add(portfolioInvestmentAllocation);
        }

        public IEnumerable<ErrorResponse> CheckValidation()
        {
            var Errors = new List<ErrorResponse>();
            if (InvestmentAmount < BusinessLogic.MinimumInvestmentAmount)
            {                
                Errors.Add(ErrorResponse.GetError(ErrorCode.AmountHastoBeMore, "Investment", BusinessLogic.MinimumInvestmentAmount));
            }
            return Errors;
        }

        public bool IsPortfolioAllocationComplete()
        {                                        
            return (InvestmentPortfolios.Sum(ip => ip.ContributionPercentage) == 1);        
        }
    }

}
