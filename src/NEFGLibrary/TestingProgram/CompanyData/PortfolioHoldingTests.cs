using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary.CompanyData;

namespace TestingProgram.CompanyData {
  [TestClass]
  public class PortfolioHoldingTests {
    [TestMethod]
    public void PopulatePortfolioAsset() {
      var assetList = ApprovedListsTests.CreateApprovedList();
      var portfolioId = 1;
      var holdingId = 1;
      var port = PortfolioHolding.CreatePortfolioHolding(assetList, portfolioId, holdingId, 0.5m);

      Assert.AreEqual(portfolioId, port.Portfolio.PortfolioId);
      Assert.AreEqual(holdingId, port.Holding.HoldingId);
      Assert.AreEqual(0.5m, port.MonthBaseValue);
    }

    [TestMethod]
    public void CreateHolding_GivenIds_ReturnsValidID() {
      var assetList = ApprovedListsTests.CreateApprovedList();
      var portfolioId = 2;
      var holdingId = 3;
      var port = PortfolioHolding.CreatePortfolioHolding(assetList, portfolioId, holdingId, 0.5m);

      var expectedId = $"P{portfolioId}:H{holdingId}";

      Assert.AreEqual(portfolioId, port.Portfolio.PortfolioId);
      Assert.AreEqual(holdingId, port.Holding.HoldingId);
      Assert.AreEqual(0.5m, port.MonthBaseValue);
      Assert.AreEqual(expectedId, port.PortfolioHoldingId);
    }
  }
}