using System.Collections.Generic;
using System.Linq;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;

namespace NEFGLibrary.Investment
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
      if (InvestmentPortfolios == null) InvestmentPortfolios = new List<PortfolioInvestmentAllocation>();
      InvestmentPortfolios.Add(portfolioInvestmentAllocation);
    }

    public List<ErrorResponse> CheckValidation()
    {
      var errors = new List<ErrorResponse>();
      if (InvestmentAmount < BusinessLogic.MinimumInvestmentAmount)
        errors.Add(ErrorResponse.GetError(ErrorCode.AmountHastoBeMore, "Investment",
          BusinessLogic.MinimumInvestmentAmount));
      return errors;
    }

    public bool IsPortfolioAllocationComplete()
    {
      return InvestmentPortfolios.Sum(ip => ip.ContributionPercentage) == 1;
    }
  }
}