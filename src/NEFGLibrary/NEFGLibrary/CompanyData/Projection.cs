using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary.CompanyData
{
    class Projection
    {
        //=(C2/12)-((1+C2)^(1/12)-1)+C2
        public static decimal ModifyGrowthPercentage(int portfolioId,int growthDataId, ApprovedLists al )
        {
            //Growth Perc Value
            var value = 0.18m;

            

            var result = (value / 12) - (DecimalPower((1 + value),(value / 12)) - 1) + value;

            return result;
            
                
        }

        public static decimal DecimalPower(decimal x, decimal y)
        {
            Double X = (double)x;
            Double Y = (double)y;
            return (decimal)System.Math.Pow(X, Y);
        }
    }
}
