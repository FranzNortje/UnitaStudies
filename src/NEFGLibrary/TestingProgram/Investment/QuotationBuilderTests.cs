using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingProgram.Investment
{
    [TestClass]
    public class QuotationBuilderTests
    {
        //Business Logic
        [TestMethod]
        public void QuotationBuilder_ShouldConstruct()
        {
            //Arrange
            var quotationBuilder = new QuotationBuilder();

            //Assign

            //Assert            
        }

        [TestMethod]
        public void AddInvestmentType_GivenInvestment_ShouldNotThrowError()
        {
            //Arrange
            var quotationBuilder = new QuotationBuilder();

            //Assign
            quotationBuilder.AddInvestmentType(CreateBuildInvestment());
            //Assert            
        }

        [TestMethod]
        public void AddInvestmentType_GivenInvestment_ShouldThrowError()
        {
            //Arrange
            var quotationBuilder = new QuotationBuilder();

            //Assign
            Assert.ThrowsException<ArgumentException>(() => quotationBuilder.AddInvestmentType(CreateBuildInvestment(0)));
            //Assert            
        }

        [TestMethod]
        public void Build_GivenSampleData_ShouldNotThrowError()
        {
            QuotationBuilder quotationBuilder = CreateQuotationBuilder();
            //Assert            
            quotationBuilder.Build();
        }

        [TestMethod]
        public void Build_GivenSampleDataWithAdviser_ShouldThrowError()
        {
            var adviser = CreateAdvisor(email: "");
            QuotationBuilder quotationBuilder ;
            //Assert            
            Assert.ThrowsException<ArgumentException>(() => quotationBuilder = CreateQuotationBuilder(adviser));
        }

        private static QuotationBuilder CreateQuotationBuilder(Adviser adviser = null)
        {
            if (adviser == null)
            {
                adviser = CreateAdvisor();
            }
            //Arrange
            var quotationBuilder = new QuotationBuilder();
            quotationBuilder.AddMorningStar(new MorningStar());
            quotationBuilder.AddProjection(new Projection());
            quotationBuilder.AddInvestorDetails(CreateInvestor());
            quotationBuilder.AddProduct(CreateProduct());
            quotationBuilder.AddAdviser(adviser);
            quotationBuilder.AddQuoteDetails(new QuoteDetails());
            quotationBuilder.AddInvestmentType(CreateBuildInvestment());
            return quotationBuilder;
        }

        private static BuildingInvestment CreateBuildInvestment(decimal investmentAmount = BusinessLogic.MinimumInvestmentAmount)
        {
            return new BuildingInvestment()
            {
                InvestmentAmount = investmentAmount
            };
        }

        private static Product CreateProduct()
        {
            return new Product()
            {
                ProductId = 1,
                ProductName = "Optimum Investment Plan",
                ProductQuotationCode = "OIP7000"
            };
        }

        private static Investor CreateInvestor()
        {
            return new Investor()
            {
                Title = title.Unknown, //not effective
                Initials = "SMPL",
                LastName = "Sample",
                DateOfBirth = DateTime.Today //todo
            };
        }

        private static Adviser CreateAdvisor(string name ="validname",string email = "Validemail@validdomain.com")
        {
            return new Adviser()
            { AdviserId = 1,
              Email = email,
              AdviserName = name
            };
        }
    }
}
