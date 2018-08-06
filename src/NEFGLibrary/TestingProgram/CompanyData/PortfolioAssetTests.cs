using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary.CompanyData;

namespace TestingProgram.CompanyData {
  [TestClass]
  public class PortfolioAssetTests {
    [TestMethod]
    public void PopulatePortfolioAsset() {
      var assetList = ApprovedListsTests.CreateApprovedList();
      var portfolioId = 1;
      var assetId = 1;
      var port = PortfolioAsset.CreatePortfolioAsset(assetList, portfolioId, assetId, 0.5m);

      Assert.AreEqual(portfolioId, port.Portfolio.PortfolioId);
      Assert.AreEqual(assetId, port.Asset.AssetId);
      Assert.AreEqual(0.5m, port.MonthBaseValue);
    }

    [TestMethod]
    public void CreateAsset_GivenIds_ReturnsValidID() {
      var assetList = ApprovedListsTests.CreateApprovedList();
      var portfolioId = 2;
      var assetId = 3;
      var port = PortfolioAsset.CreatePortfolioAsset(assetList, portfolioId, assetId, 0.5m);

      var expectedId = $"P{portfolioId}:A{assetId}";

      Assert.AreEqual(portfolioId, port.Portfolio.PortfolioId);
      Assert.AreEqual(assetId, port.Asset.AssetId);
      Assert.AreEqual(0.5m, port.MonthBaseValue);
      Assert.AreEqual(expectedId, port.PortfolioAssetId);
    }
  }
}