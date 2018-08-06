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
  }
}