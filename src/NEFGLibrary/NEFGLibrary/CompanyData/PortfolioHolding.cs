using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary.CompanyData
{
    public class PortfolioHolding
    {
        public Portfolio Portfolio { get; set; }
        public Holding Holding {get;set;}        
        public decimal MonthBaseValue { get; set; }
    }
}
