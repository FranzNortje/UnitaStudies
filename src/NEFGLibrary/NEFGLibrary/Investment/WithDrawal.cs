using System.Collections.Generic;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;

namespace NEFGLibrary.Investment
{
  public class WithDrawal : IWithDrawel
  {
    public IncomeWithDrawelType IncomeWithdrawalType { get; set; }
    public decimal IncomeDrawdownAmount { get; set; }
    public decimal IncomeDrawdownPercentage { get; set; }
    public decimal MontlyWithdrawelAmount { get; set; }
    public decimal MontlyWithdrawelPercentage { get; set; }
    public WithDrawalOption IncomeDrawdownOption { get; set; }
    public decimal IncomeDrawdownInLineWithCpi { get; set; }
    public decimal WithdrawalEscalationRatePerAnnum { get; set; }
    public int IncomeEscalationInterval { get; set; }
    public decimal MonthlyTaxDeducted { get; set; }
    public decimal MonthlyIncomeAfterTax { get; set; }

    public List<ErrorResponse> CheckValidation()
    {
      return new List<ErrorResponse>();
    }
  }
}