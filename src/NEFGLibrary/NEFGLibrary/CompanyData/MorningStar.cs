using System;
using System.Collections.Generic;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;
using System.Linq;

namespace NEFGLibrary.CompanyData
{
  public class MorningStar : IValidator
  {
      

    public int MorningStarVersion { get; set; }
    public DateTime DirectDataDateAssetAllocation { get; set; }
    public DateTime DirectDataDatePerformances { get; set; }
    public DateTime DirectDataDateHoldings { get; set; }
    public List<PortfolioHolding> PortfolioHoldings { get; set; }
    public List<PortfolioAsset> PortfolioAssets { get; set; }
    public List<PortfolioGrowthData> PortfolioGrowthDataInfo { get; set; }

        public List<ErrorResponse> CheckValidation()
    {
      return new List<ErrorResponse>();
    }


        public static decimal GetSpecificGrowthDataValue(int portfolioId, int growthDataId, MorningStar ms)
        {
            string check = $"P{portfolioId}:G{growthDataId}";
            return ms.PortfolioGrowthDataInfo.First(pg => pg.GrowthdataId == check).MonthBaseValue;
        }
    }
}