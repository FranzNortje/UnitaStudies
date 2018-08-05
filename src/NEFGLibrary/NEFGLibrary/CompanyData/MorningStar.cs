using NEFGLibrary.CompanyData;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary
{
    public class MorningStar
    {
        public int MorningStarVersion { get; set; }
        public DateTime DirectDataDateAssetAllocation { get; set; }
        public DateTime DirectDataDatePerformances { get; set; }
        public DateTime DirectDataDateHoldings { get; set; }
        public List<PortfolioHolding> PortfolioHoldings { get; set; }
        public List<PortfolioAsset> PortfolioAssets { get; set; }
    }
}
