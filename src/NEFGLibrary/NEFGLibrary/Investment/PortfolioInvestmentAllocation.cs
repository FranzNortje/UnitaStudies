using NEFGLibrary.CompanyData;

namespace NEFGLibrary.Investment
{
  public class PortfolioInvestmentAllocation
  {
    public int InvestmentAllocationId { get; set; }
    public Portfolio InvestmentPortfolio { get; set; }
    public decimal ContributionPercentage { get; set; }
  }
}