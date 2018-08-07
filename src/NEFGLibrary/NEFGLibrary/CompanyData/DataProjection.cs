using System;
using System.Collections.Generic;
using System.Text;


namespace NEFGLibrary.CompanyData
{
    public class DataProjection
    {
        //=(C2/12)-((1+C2)^(1/12)-1)+C2
        public static decimal ModifyGrowthPercentage(int portfolioId,int growthDataId,MorningStar ms)
        {
            //Growth Perc Value
            var value = MorningStar.GetSpecificGrowthDataValue(portfolioId, growthDataId, ms);
            return (value / 12) - (DecimalPower((1 + value),(value / 12)) - 1) + value;
            // ((0.065)/12)-(POWER((1+(0.065)),(1/12))-1)+(0.065)
        }

        // need to figure this out
        //https://www.extremeoptimization.com/Documentation/Reference/Extreme.Mathematics.DecimalMath.Pow-1.aspx
        // method below ineffective - returns inaccurate result
        private static decimal DecimalPower(decimal x, decimal y)
        {
            Double X = (double)x;
            Double Y = (double)y;
            return (decimal)System.Math.Pow(X, Y);
        }
    }
}
