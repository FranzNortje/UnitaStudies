using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary.CompanyData
{
    public class PortfolioAsset
    {
        public Portfolio Portfolio { get; set; }
        public Asset Asset { get; set; }
        public decimal MonthBaseValue { get; set; }
    }
}
