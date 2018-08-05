using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary
{
    public static class BusinessLogic
    {
        public const decimal MinimumInvestmentAmount = 100.01m;

        public static class Calculation
        {
            //MonthlyAmount - (MonthlyAmount * (InitialFinancialAdviserFee * 1.15));
            public static decimal FinancialAdviserFee(decimal InitialAmount, decimal InitialFinancialAdviserFee, decimal Multiplier)
                => (InitialAmount * (InitialFinancialAdviserFee * Multiplier));

            public static decimal InvestmentAfterFinancialAdviserFee(decimal InitialAmount, decimal InitialFinancialAdviserFee, decimal Multiplier)
                => InitialAmount - FinancialAdviserFee(InitialAmount, InitialFinancialAdviserFee, Multiplier);
        }

        public static class InvestmentCalc
        {
            
        }

        public static class CalculateHoldings
        {
           //return investment type holdings list


        }

        public static class CalculateAssets
        {
            //return investment type asset list
        }
    }
}
