using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary.CompanyData
{
    public class PortfolioAsset
    {
        public string PortfolioAssetId { get; set; }
        public Portfolio Portfolio { get; set; }
        public Asset Asset { get; set; }
        public decimal MonthBaseValue { get; set; }

        public static PortfolioAsset CreatePortfolioAsset(ApprovedLists al, int portfolioId, int assetId, decimal monthBaseValue)
        {
            var portfolioAsset = new PortfolioAsset()
            {
                PortfolioAssetId = $"P{portfolioId}:A{assetId}",
                Portfolio = al.GetPortfolioById(portfolioId),
                Asset = al.GetAssetById(assetId),
                MonthBaseValue = monthBaseValue

            };

            return portfolioAsset;
        }

    }

}
