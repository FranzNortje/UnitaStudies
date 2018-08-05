using NEFGLibrary.Investment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEFGLibrary
{
    public class QuotationBuilder
    {
        private List<IInvestment> _InvestmentStructure;
        private List<IProjection> _InvestmentProjections;
        private IWithDrawel _InvestmentWithDrawel;
        private MorningStar _morningstarInfo;
        private Investor _InvestorDetails;
        private Product _Product;
        private Adviser _InvestmentAdviser;
        private QuoteDetails _quoteDetails;

        public QuotationBuilder()
        {
            _InvestmentStructure = new List<IInvestment>();
            _InvestmentProjections = new List<IProjection>();
        }

        public void AddInvestmentType(IInvestment investment)
        {
            ValidateInput(investment);
            _InvestmentStructure.Add(investment);            
        }

        public void AddWithDrawel(IWithDrawel withDrawel)
        {
            _InvestmentWithDrawel = withDrawel;
        }

        public void AddProjection(IProjection projection)
        {
            _InvestmentProjections.Add(projection);
        }
        public void AddMorningStar(MorningStar morningStar)
        {
            _morningstarInfo = morningStar;
        }
        public void AddInvestorDetails(Investor investor)
        {
            ValidateInput(investor);
            _InvestorDetails = investor;
        }
        public void AddProduct(Product product)
        {
            ValidateInput(product);
            _Product = product;
        }
       
        public void AddAdviser(Adviser adviser)
        {
            ValidateInput(adviser);
            _InvestmentAdviser = adviser;
        }

        public void AddQuoteDetails(QuoteDetails quoteDetails)
        {
            _quoteDetails = quoteDetails;
        }

        public void Build()
        {
            if (_morningstarInfo == null) throw new ArgumentNullException("Run AddMorningStar before building.");
            if (_InvestmentStructure.Count == 0) throw new ArgumentException("Ensure at least one investment type is added");
            if (_InvestmentProjections.Count == 0) throw new ArgumentException("Ensure at least one Projection is added");
            if (_InvestorDetails == null) throw new ArgumentNullException("Add Investor before building");
            if (_Product == null) throw new ArgumentNullException("Add Product before building");
            if (_InvestmentAdviser == null) throw new ArgumentNullException("Add Investment Adviser before building");
            if (_quoteDetails == null) throw new ArgumentNullException("Add Quote Details before building");
           
        }

        private static void ValidateInput(IValidator input)
        {
            var errors = input.CheckValidation();
            if (errors.ToList().Count > 0)
            {
                throw new ArgumentException(errors.First().ErrorReason);
            }
        }
    }

}
