using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary.Investment;

namespace TestingProgram.Investment {
  [TestClass]
  public class BuildingInvestmentTests {
    //Business Logic
    [TestMethod]
    public void IsPortfolioAllocationComplete_GivenValidPortfolio_ReturnsTrue() {
      //Arrange
      var buildingInvestment = new BuildingInvestment();
      buildingInvestment.AddPortfolioAllocation(new PortfolioInvestmentAllocation {
        ContributionPercentage = 1
      });
      //Assign
      var result = buildingInvestment.IsPortfolioAllocationComplete();

      //Assert
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPortfolioAllocationComplete_GivenInValidPortfolio_ReturnsFalse() {
      //Arrange
      var buildingInvestment = new BuildingInvestment();
      buildingInvestment.AddPortfolioAllocation(new PortfolioInvestmentAllocation {
        ContributionPercentage = 0.999999m
      });
      //Assign
      var result = buildingInvestment.IsPortfolioAllocationComplete();

      //Assert
      Assert.IsFalse(result);
    }

         
    /*
     *    public InvestmentTypes InvestmentType { get; set; }

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

    */

  }
}
 