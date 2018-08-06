namespace NEFGLibrary.CompanyData
{
  public class PortfolioHolding
  {
    public string PortfolioHoldingId { get; set; }
    public Portfolio Portfolio { get; set; }
    public Holding Holding { get; set; }
    public decimal MonthBaseValue { get; set; }

    public static PortfolioHolding CreatePortfolioHolding(ApprovedLists al, int portfolioId, int holdingId,
      decimal monthBaseValue)
    {
      var portFolioHolding = new PortfolioHolding {
        PortfolioHoldingId = $"P{portfolioId}:H{holdingId}",
        Portfolio = al.GetPortfolioById(portfolioId),
        Holding = al.GetHoldingById(holdingId),
        MonthBaseValue = monthBaseValue
      };
      return portFolioHolding;
    }
  }
}