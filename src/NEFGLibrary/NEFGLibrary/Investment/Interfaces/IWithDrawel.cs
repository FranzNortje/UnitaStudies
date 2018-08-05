namespace NEFGLibrary
{
    public interface IWithDrawel
    {
        IncomeWithDrawelType IncomeWithdrawalType { get; set; }
         decimal IncomeDrawdownAmount { get; set; }
         decimal IncomeDrawdownPercentage { get; set; }
         decimal MontlyWithdrawelAmount { get; set; }
         decimal MontlyWithdrawelPercentage { get; set; }
        WithDrawelOption IncomeDrawdownOption { get; set; }
         decimal IncomeDrawdownInLineWithCPI { get; set; }
         decimal WithdrawalEscalationRatePerAnnum { get; set; }
         int IncomeEscalationInterval { get; set; }
        decimal MonthlyTaxDeducted { get; set; }
        decimal MonthlyIncomeAfterTax { get; set; }
    }

}
