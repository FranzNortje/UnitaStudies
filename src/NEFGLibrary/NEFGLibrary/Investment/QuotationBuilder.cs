using System;
using System.Collections.Generic;
using System.Linq;
using NEFGLibrary.CompanyData;
using NEFGLibrary.Investment.Interfaces;

namespace NEFGLibrary.Investment
{
  public class QuotationBuilder
  {
    private readonly List<IProjection> _investmentProjections;
    private readonly List<IInvestment> _investmentStructure;
    private Adviser _investmentAdviser;
    private IWithDrawel _investmentWithDrawal;
    private Investor _investorDetails;
    private MorningStar _morningstarInfo;
    private Product _product;
    private QuoteDetails _quoteDetails;

    public QuotationBuilder()
    {
      _investmentStructure = new List<IInvestment>();
      _investmentProjections = new List<IProjection>();
    }

    public void AddInvestmentType(IInvestment investment)
    {
      ValidateInput(investment);
      _investmentStructure.Add(investment);
    }

    public void AddWithDrawel(IWithDrawel withDrawel)
    {
      ValidateInput(withDrawel);
      _investmentWithDrawal = withDrawel;
    }

    public void AddProjection(IProjection projection)
    {
      ValidateInput(projection);
      _investmentProjections.Add(projection);
    }

    public void AddMorningStar(MorningStar morningStar)
    {
      ValidateInput(morningStar);
      _morningstarInfo = morningStar;
    }

    public void AddInvestorDetails(Investor investor)
    {
      ValidateInput(investor);
      _investorDetails = investor;
    }

    public void AddProduct(Product product)
    {
      ValidateInput(product);
      _product = product;
    }

    public void AddAdviser(Adviser adviser)
    {
      ValidateInput(adviser);
      _investmentAdviser = adviser;
    }

    public void AddQuoteDetails(QuoteDetails quoteDetails)
    {
      ValidateInput(quoteDetails);
      _quoteDetails = quoteDetails;
    }

    public void Build()
    {
      if (_morningstarInfo == null) throw new ArgumentNullException("Run AddMorningStar before building.");
      if (_investmentStructure.Count == 0) throw new ArgumentException("Ensure at least one investment type is added");
      if (_investmentProjections.Count == 0) throw new ArgumentException("Ensure at least one Projection is added");
      if (_investorDetails == null) throw new ArgumentNullException("Add Investor before building");
      if (_product == null) throw new ArgumentNullException("Add Product before building");
      if (_investmentAdviser == null) throw new ArgumentNullException("Add Investment Adviser before building");
      if (_quoteDetails == null) throw new ArgumentNullException("Add Quote Details before building");
    }

    private static void ValidateInput(IValidator input)
    {
      var errors = input.CheckValidation();
      if (errors.Count > 0) throw new ArgumentException(errors.First().ErrorReason);
    }
  }
}