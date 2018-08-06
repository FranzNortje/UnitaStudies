using System;
using System.Collections.Generic;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;

namespace NEFGLibrary
{
  public class QuoteDetails : IValidator
  {
    public string QuoteType { get; set; }
    public int QuoteId { get; set; }

    public string ClientName { get; set; }
    public DateTime QuotationDate { get; set; }
    public string ProductName { get; set; }

    public string HeadingTextInvestmentType1 { get; set; }
    public string HeadingTextInvestmentType2 { get; set; }
    public string HeadingTextInvestmentType3 { get; set; }
    public string HeadingTextTopAmount { get; set; }
    public string HeadingTextBottomAmount { get; set; }
    public string HeadingTextQuotationNumber { get; set; }
    public List<string> ImportantProductInfo { get; set; }

    //Single Investment
    public string InvestmentPortfolioAllocationGraphHeading1 { get; set; }
    public string InvestmentPortfolioAllocationGraphHeadingAmount1 { get; set; }

    //Monthly Investment
    public string InvestmentPortfolioAllocationGraphHeading2 { get; set; }
    public string InvestmentPortfolioAllocationGraphHeadingAmount2 { get; set; }

    //Monthly Withdrawel
    public string InvestmentPortfolioAllocationGraphHeading3 { get; set; }
    public string InvestmentPortfolioAllocationGraphHeadingAmount3 { get; set; }

    // Monthly Quote Variation
    public decimal SingleInvestmentContributionAmount { get; set; }
    public decimal MonthlyInvestmentContributionAmount { get; set; }

    public decimal MonthlyEscalation { get; set; }

    // Holdings - Graph
    // Asset Allocations - Graph
    // Portfolio Performance
    // Performance Graph
    // Fees you will pay
    // Total Annual Investment Summary
    // Projection
    // ----------
    // Product Type
    // Inception Date
    // Maturity Date
    // Long Term Inflation Rate(CPI)
    // Expected Growth per Annum
    // *NAV
    // Single Investment Before initial fees
    // Single Investment After initial fees
    // Monthly Investment Before initial fees
    // Monthly Investment After initial fees
    // Escalation rate per annum
    // 
    // Projection Table
    // YEAR | Monthly Contribution | total Annual investment | low growth | target growth | high growth
    // 
    // Gross Investment
    // Projected value
    // Expected growth - graph
    // 
    // PDFs
    // 

    //FontStyle == Univers LT 47 CondensedLt
    /*
      public Quote(MonthlyInvestment mi)
      {
          string taxheading = "Tax will be deducted from your annuity income payments.Your monthly annuity income is paid at the end of the month.";
          ClientName = mi.InvestorDetails.Initials + " " + mi.InvestorDetails.Initials + " " + mi.InvestorDetails.LastName;
          QuotationDate = mi.InvestmentDate;
          ProductName = mi.ChosenProduct.ProductName;
          QuoteType = mi.GetDescription();
          MonthlyInvestmentContributionAmount = mi.MonthlyAmount;
          MonthlyEscalation = mi.EscalationRatePerAnnum;
          HeadingTextInvestmentType1 = "Monthly Investment Contribution";
          HeadingTextTopAmount = MonthlyInvestmentContributionAmount.ToString();
          HeadingTextInvestmentType2 = MonthlyEscalation > 0 ? String.Format("({0}% escalation per year", MonthlyEscalation) : "";
          HeadingTextQuotationNumber = mi.ChosenProduct.ProductQuotationCode + mi.QuotationNr.ToString();
          if (ProductName == "Optimum Living Annuity") HeadingTextInvestmentType3 = taxheading;
          ImportantProductInfo = mi.ChosenProduct.ProductInfo;


      }

      public Quote(SingleAndMonthlyInvestment sam)
      {
          ClientName = sam.InvestorDetails.Initials + " " + sam.InvestorDetails.Initials + " " + sam.InvestorDetails.LastName;
          QuotationDate = sam.InvestmentDate;
          ProductName = sam.ChosenProduct.ProductName;
          QuoteType = sam.GetDescription();
          SingleInvestmentContributionAmount = sam.SingleAmount;
          MonthlyInvestmentContributionAmount = sam.MonthlyAmount;
          MonthlyEscalation = sam.EscalationRatePerAnnum;

      }

      public Quote(SingleInvestment si)
      {
          ClientName = si.InvestorDetails.Initials + " " + si.InvestorDetails.Initials + " " + si.InvestorDetails.LastName;
          QuotationDate = si.InvestmentDate;
          ProductName = si.ChosenProduct.ProductName;
          QuoteType = si.GetDescription();
          SingleInvestmentContributionAmount = si.SingleAmount;
      }

      public Quote(SingleInvestmentWithWithdrawel siw)
      {
          ClientName = siw.InvestorDetails.Initials + " " + siw.InvestorDetails.Initials + " " + siw.InvestorDetails.LastName;
          QuotationDate = siw.InvestmentDate;
          ProductName = siw.ChosenProduct.ProductName;
          QuoteType = siw.GetDescription();
          SingleInvestmentContributionAmount = siw.SingleAmount;

      }
      */

    public List<ErrorResponse> CheckValidation()
    {
      return new List<ErrorResponse>();
    }
  }
}