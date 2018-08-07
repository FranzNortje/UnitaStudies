using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary.CompanyData
{
    public class GrowthData
    {
        public int GrowthDataId { get; set; }
        public Growth Growth { get; set; }

    }

    public enum Growth
    {
        Low = 1,
        Target,
        High
    }
}
