namespace NEFGLibrary.Investment.Interfaces
{
  public interface IWithDrawel : IValidator
  {
    IncomeWithDrawelType IncomeWithdrawalType { get; set; }
    decimal IncomeDrawdownAmount { get; set; }
    decimal IncomeDrawdownPercentage { get; set; }
    decimal MontlyWithdrawelAmount { get; set; }
    decimal MontlyWithdrawelPercentage { get; set; }
    WithDrawalOption IncomeDrawdownOption { get; set; }
    decimal IncomeDrawdownInLineWithCpi { get; set; }
    decimal WithdrawalEscalationRatePerAnnum { get; set; }
    int IncomeEscalationInterval { get; set; }
    decimal MonthlyTaxDeducted { get; set; }
    decimal MonthlyIncomeAfterTax { get; set; }
  }
}