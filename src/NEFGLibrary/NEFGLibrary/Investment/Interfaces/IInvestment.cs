using System.Collections.Generic;

namespace NEFGLibrary.Investment.Interfaces
{
  public interface IInvestment : IValidator
  {
    InvestmentTypes InvestmentType { get; set; }
    decimal InvestmentAmount { get; set; }
    decimal InvestmentAmountAfterInitialFinancialAdviserFee { get; set; }
    decimal EscalationRatePerAnnum { get; set; }
    List<PortfolioInvestmentAllocation> InvestmentPortfolios { get; set; }

    void AddPortfolioAllocation(PortfolioInvestmentAllocation portfolioInvestmentAllocation);
    bool IsPortfolioAllocationComplete();
  }
}