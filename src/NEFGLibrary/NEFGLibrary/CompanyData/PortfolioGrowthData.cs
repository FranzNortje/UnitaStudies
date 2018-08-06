using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary.CompanyData
{
    public class PortfolioGrowthData
    {
        public string GrowthdataId { get; set; }
        public Portfolio Portfolio { get; set; }
        public GrowthData GrowthData { get; set; }
        public decimal MonthBaseValue { get; set; }

        public static PortfolioGrowthData CreatePortfolioGrowthData(ApprovedLists al, int portfolioId, int growthId)
        {
            var portfolioGrowthData = new PortfolioGrowthData
            {
                GrowthdataId = $"P{portfolioId}:G{growthId}",
                Portfolio = al.GetPortfolioById(portfolioId),
                GrowthData = al.GetGrowthDataById(growthId)
            };
            return portfolioGrowthData;
        }

        
    }
}

