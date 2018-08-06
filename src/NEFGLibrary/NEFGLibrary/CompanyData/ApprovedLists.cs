using System.Collections.Generic;
using System.Linq;

namespace NEFGLibrary.CompanyData
{
  public class ApprovedLists
  {
    public ApprovedLists()
    {
      Portfolios = new List<Portfolio>();
      Holdings = new List<Holding>();
      Assets = new List<Asset>();
      GrowthdataInfo = new List<GrowthData>();

    }

    public List<Portfolio> Portfolios { get; set; }
    public List<Holding> Holdings { get; set; }
    public List<Asset> Assets { get; set; }
    public List<GrowthData> GrowthdataInfo { get; set; }

    public GrowthData GetGrowthDataById(int id)
    {
            return GrowthdataInfo.First(g => g.GrowthDataId == id);

    }

    public Asset GetAssetById(int id)
    {
      return Assets.First(a => a.AssetId == id);
    }

    public Holding GetHoldingById(int id)
    {
      return Holdings.First(h => h.HoldingId == id);
    }

    public Portfolio GetPortfolioById(int id)
    {
      return Portfolios.First(p => p.PortfolioId == id);
    }

    public GrowthData AddGrowthData(Growth growth)
        {
            var newGrowthData = new GrowthData
            {
                GrowthDataId = GrowthdataInfo.Count + 1,
                Growth = growth
            };
            GrowthdataInfo.Add(newGrowthData);
            return newGrowthData;
        }

    public Portfolio AddPortfolio(string portfolioName)
    {
      var newPortfolio = new Portfolio {
        PortfolioId = Portfolios.Count + 1,
        PortfolioName = portfolioName
      };
      Portfolios.Add(newPortfolio);
      return newPortfolio;
    }

    public Holding AddHolding(string holdingname)
    {
      var newHolding = new Holding {
        HoldingId = Holdings.Count + 1,
        HoldingName = holdingname
      };
      Holdings.Add(newHolding);
      return newHolding;
    }

    public Asset AddAsset(string assetname)
    {
      var newAsset = new Asset {
        AssetId = Assets.Count + 1,
        AssetName = assetname
      };
      Assets.Add(newAsset);
      return newAsset;
    }
  }
}