namespace NEFGLibrary
{
  public static class BusinessLogic
  {
    public const decimal MinimumInvestmentAmount = 100.01m;

    public static class Calculation
    {
      //MonthlyAmount - (MonthlyAmount * (InitialFinancialAdviserFee * 1.15));
      public static decimal FinancialAdviserFee(decimal initialAmount, decimal initialFinancialAdviserFee,
        decimal multiplier)
      {
        return initialAmount * initialFinancialAdviserFee * multiplier;
      }

      public static decimal InvestmentAfterFinancialAdviserFee(decimal initialAmount,
        decimal initialFinancialAdviserFee, decimal multiplier)
      {
        return initialAmount - FinancialAdviserFee(initialAmount, initialFinancialAdviserFee, multiplier);
      }
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