namespace NEFGLibrary
{
    public class WithDrawel : IWithDrawel
    {
        public IncomeWithDrawelType IncomeWithdrawalType { get; set; }
        public decimal IncomeDrawdownAmount { get; set; }
        public decimal IncomeDrawdownPercentage { get; set; }
        public decimal MontlyWithdrawelAmount { get; set; }
        public decimal MontlyWithdrawelPercentage { get; set; }
        public WithDrawelOption IncomeDrawdownOption { get; set; }
        public decimal IncomeDrawdownInLineWithCPI { get; set; }
        public decimal WithdrawalEscalationRatePerAnnum { get; set; }
        public int IncomeEscalationInterval { get; set; }
        public decimal MonthlyTaxDeducted { get; set; }
        public decimal MonthlyIncomeAfterTax { get; set; }
    }

}
