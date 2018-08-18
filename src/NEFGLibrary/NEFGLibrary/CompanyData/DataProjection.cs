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

            decimal monthVal = value / (decimal)12; //0.00541666666666667
            decimal x = (decimal)1 + value;         //
            decimal y = (decimal)1 / (decimal)12;

            decimal PowerValue = DecimalPower(x, y); //1.00526169427685
            decimal PowerValueResult = PowerValue - (decimal)1; //0.00526169427684775
            decimal result = monthVal - PowerValueResult + value; 

            
            return result;

            //0.06515497238981
            //0.0651549723898189 Excel
            //0.0651549723898167 C#


        }

        private static decimal DecimalPower(decimal x, decimal y)
        {
            Double X = (double)x;
            Double Y = (double)y;
            return (decimal)System.Math.Pow(X, Y);
        }

    
    }
}
