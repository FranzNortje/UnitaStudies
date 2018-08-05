using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NEFGLibrary.CompanyData
{
    public class ApprovedLists
    {
        public List<Portfolio> Portfolios { get; set; }
        public List<Holding> Holdings { get; set; }
        public List<Asset> Assets { get; set; }

        public ApprovedLists()
        {
            Portfolios = new List<Portfolio>();
            Holdings = new List<Holding>();
            Assets = new List<Asset>();

        }

        public Portfolio AddPortfolio(string portfolioName)
        {
            var newPortfolio = new Portfolio()
            {
                PortfolioId = Portfolios.Count() + 1,
                PortfolioName = portfolioName
            };
            Portfolios.Add(newPortfolio);
            return newPortfolio;
        }

        public Holding AddHolding(string holdingname)
        {
            var newHolding = new Holding()
            {
                 HoldingId = Holdings.Count() + 1,
                 HoldingName = holdingname
            };
            Holdings.Add(newHolding);
            return newHolding;
        }

        public Asset AddAsset(string assetname)
        {
            var newAsset = new Asset()
            {
                 AssetId = Assets.Count() + 1,
                  AssetName = assetname
            };
            Assets.Add(newAsset);
            return newAsset;
        }
       
    }
}
