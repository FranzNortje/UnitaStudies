using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary;
using System.Collections.Generic;

namespace TestingProgram
{
    [TestClass]
    public class InputTest
    {
        //Business Logic
        [TestMethod]
        public void CalculateFinancialAdviserFeeTest()
        {
            //Arrange
            var InitialAmount = 5000m;
            var InitialAdvisorFee = 0.01m;
            var Multiplier = 1.15m;
            var RemainingAfterFinancialAdviserFee = 4942.50m;

            //Assign
            var result = BusinessLogic.Calculation.FinancialAdviserFee(InitialAmount, InitialAdvisorFee, Multiplier);

            //Assert
            Assert.AreEqual(InitialAmount, RemainingAfterFinancialAdviserFee + result);
        }

        [TestMethod]
        public void CalculateInvestmentAfterFinancialAdviserFeeTest() => Assert.AreEqual(4942.50m, BusinessLogic.Calculation.InvestmentAfterFinancialAdviserFee(5000m, 0.01m, 1.15m));


        /*

        //Capture Sheet Concept

        [TestMethod]
        public void MonthlyInvestmentTest()
        {
            MonthlyInvestment mi = new MonthlyInvestment();
            mi.MonthlyAmount = 200;
            mi.InitialFinancialAdviserFee = 0.01;

            mi.CalculateMonthlyInvestmentAmountAfterInitialFinancialAdviserFee();
            Assert.AreEqual(197.7, mi.MonthlyInvestmentAmountAfterInitialFinancialAdviserFee);
        }

        [TestMethod]
        public void SingleInvestmentTest()
        {
            SingleInvestment mi = new SingleInvestment();
            mi.SingleAmount = 100000;
            mi.InitialFinancialAdviserFee = 0.01;

            mi.CalculateSingleInvestmentAmountAfterInitialFinancialAdviserFee();
            Assert.AreEqual(98850, mi.SingleInvestmentAmountAfterInitialFinancialAdviserFee);
        }

        [TestMethod]
        public void SingleAndMonthlyInvestmentTest()
        {
            SingleAndMonthlyInvestment mi = new SingleAndMonthlyInvestment();
            mi.SingleAmount = 100000;
            mi.InitialFinancialAdviserFee = 0.01;

            mi.CalculateSingleInvestmentAmountAfterInitialFinancialAdviserFee();
            mi.MonthlyAmount = 200;
            mi.InitialFinancialAdviserFee = 0.01;

            mi.CalculateMonthlyInvestmentAmountAfterInitialFinancialAdviserFee();
            Assert.AreEqual(197.7, mi.MonthlyInvestmentAmountAfterInitialFinancialAdviserFee);
            Assert.AreEqual(98850, mi.SingleInvestmentAmountAfterInitialFinancialAdviserFee);
        }

        [TestMethod]
        public void SingleInvestmentWithWithdrawalTest()
        {
            SingleInvestmentWithWithdrawel mi = new SingleInvestmentWithWithdrawel();
            mi.SingleAmount = 100000;
            mi.InitialFinancialAdviserFee = 0.01;

            mi.CalculateSingleInvestmentAmountAfterInitialFinancialAdviserFee();
            Assert.AreEqual(98850, mi.SingleInvestmentAmountAfterInitialFinancialAdviserFee);
        }

        [TestMethod]
        public void CheckPortfolioSumMonthlyTest()
        {
            MonthlyInvestment mi = new MonthlyInvestment();

            mi.MonthlyAmount = 200;
            mi.InitialFinancialAdviserFee = 0.01;

            mi.CalculateMonthlyInvestmentAmountAfterInitialFinancialAdviserFee();


            Product p1 = new Product();
            p1.ProductName = "Optimum Living Annuity";
            p1.ProductQuotationCode = "OLA7000";
            Product p2 = new Product();
            p2.ProductName = "Optimum Retirement Annuity Fund";
            p2.ProductQuotationCode = "ORA7000";

            Product p3 = new Product();
            p3.ProductName = "Optimum Investment Plan";
            p3.ProductQuotationCode = "OIP7000";
            Product p4 = new Product();
            p4.ProductName = "Optimum Preservation Pension Fund";
            Product p5 = new Product();
            p5.ProductName = "Optimum Preservation Provident Fund";



            Portfolio prt1 = new Portfolio();
            prt1.PortfolioName = "N-e-FG Moderate Portfolio";
            Portfolio prt2 = new Portfolio();
            prt2.PortfolioName = "Consolidator Portfolio";
            Portfolio prt3 = new Portfolio();
            prt3.PortfolioName = "Institutional Cash Plus Account";
            Portfolio prt4 = new Portfolio();
            prt4.PortfolioName = "Protector Portfolio";
            Portfolio prt5 = new Portfolio();
            prt5.PortfolioName = "Builder Portfolio";

            PortfolioInvestmentAllocation set1 = new PortfolioInvestmentAllocation();
            set1.InvestmentAllocationId = 1;
            set1.InvestmentPortfolio = prt1;
            set1.ContributionPercPerPortfolio = 0.90;

            PortfolioInvestmentAllocation set2 = new PortfolioInvestmentAllocation();
            set2.InvestmentAllocationId = 2;
            set2.InvestmentPortfolio = prt2;
            set2.ContributionPercPerPortfolio = 0.10;

            mi.InvestmentPortfolios.Add(set1);
            mi.InvestmentPortfolios.Add(set2);



            Assert.AreEqual(true, actual: mi.CheckPortfolioSum);




        }

        [TestMethod]
        public void CheckProductInfoTest()
        {
            MonthlyInvestment mi = new MonthlyInvestment();

            mi.MonthlyAmount = 200;
            mi.InitialFinancialAdviserFee = 0.01;

            mi.CalculateMonthlyInvestmentAmountAfterInitialFinancialAdviserFee();


            Product p1 = new Product();
            p1.ProductName = "Optimum Living Annuity";
            p1.ProductQuotationCode = "OLA7000";
            Product p2 = new Product();
            p2.ProductName = "Optimum Retirement Annuity Fund";
            p2.ProductQuotationCode = "ORA7000";

            Product p3 = new Product();
            p3.ProductName = "Optimum Investment Plan";
            p3.ProductQuotationCode = "OIP7000";
            Product p4 = new Product();
            p4.ProductName = "Optimum Preservation Pension Fund";
            Product p5 = new Product();
            p5.ProductName = "Optimum Preservation Provident Fund";

            QuoteInfo q1 = new QuoteInfo();
            q1.QuoteString = "Important Information";
            QuoteInfo q2 = new QuoteInfo();
            q2.QuoteString = "Line1";
            QuoteInfo q3 = new QuoteInfo();
            q3.QuoteString = "Line2";
            QuoteInfo q4 = new QuoteInfo();
            q4.QuoteString = "Line3";

            p1.ProductList = new List<QuoteInfo>();
            p1.ProductList.Add(q1);
            p1.ProductList.Add(q2);
            p1.ProductList.Add(q3);
            p1.ProductList.Add(q4);

            List<string> checklist = new List<string>();
            checklist.Add("Important Information");
            checklist.Add("Line1");
            checklist.Add("Line2");
            checklist.Add("Line3");

            p1.SetProductInfo();

            List<string> test = p1.ProductInfo;

            bool check = false;
            for (int i = 0; i < 4; i++)
            {
                check = checklist[i] == test[i];
            }

            
           

            Assert.AreEqual(true,check);





        }

        [TestMethod]
        public void CheckPortfolioSumSingleTest()
        {
            SingleInvestment si = new SingleInvestment();

            si.SingleAmount = 200;
            si.InitialFinancialAdviserFee = 0.01;

            si.CalculateSingleInvestmentAmountAfterInitialFinancialAdviserFee();


            Product p1 = new Product();
            p1.ProductName = "Optimum Living Annuity";
            Product p2 = new Product();
            p2.ProductName = "Optimum Retirement Annuity Fund";
            Product p3 = new Product();
            p3.ProductName = "Optimum Investment Plan";

            Portfolio prt1 = new Portfolio();
            prt1.PortfolioName = "N-e-FG Moderate Portfolio";
            Portfolio prt2 = new Portfolio();
            prt2.PortfolioName = "Consolidator Portfolio";
            Portfolio prt3 = new Portfolio();
            prt3.PortfolioName = "Institutional Cash Plus Account";
            Portfolio prt4 = new Portfolio();
            prt4.PortfolioName = "Protector Portfolio";
            Portfolio prt5 = new Portfolio();
            prt5.PortfolioName = "Builder Portfolio";

            PortfolioInvestmentAllocation set1 = new PortfolioInvestmentAllocation();
            set1.InvestmentAllocationId = 1;
            set1.InvestmentPortfolio = prt1;
            set1.ContributionPercPerPortfolio = 0.90;

            PortfolioInvestmentAllocation set2 = new PortfolioInvestmentAllocation();
            set2.InvestmentAllocationId = 2;
            set2.InvestmentPortfolio = prt2;
            set2.ContributionPercPerPortfolio = 0.10;
            
            si.SingleInvestmentPortfolios.Add(set1);
            si.SingleInvestmentPortfolios.Add(set2);


            
            Assert.AreEqual(true, actual: si.CheckPortfolioSum);
            



        }

        [TestMethod]
        public void CheckPortfolioSumSingleWithWithdrawalTest()
        {
            SingleInvestmentWithWithdrawel si = new SingleInvestmentWithWithdrawel();

            si.SingleAmount = 200;
            si.InitialFinancialAdviserFee = 0.01;

            si.CalculateSingleInvestmentAmountAfterInitialFinancialAdviserFee();


            Product p1 = new Product();
            p1.ProductName = "Optimum Living Annuity";
            Product p2 = new Product();
            p2.ProductName = "Optimum Retirement Annuity Fund";
            Product p3 = new Product();
            p3.ProductName = "Optimum Investment Plan";

            Portfolio prt1 = new Portfolio();
            prt1.PortfolioName = "N-e-FG Moderate Portfolio";
            Portfolio prt2 = new Portfolio();
            prt2.PortfolioName = "Consolidator Portfolio";
            Portfolio prt3 = new Portfolio();
            prt3.PortfolioName = "Institutional Cash Plus Account";
            Portfolio prt4 = new Portfolio();
            prt4.PortfolioName = "Protector Portfolio";
            Portfolio prt5 = new Portfolio();
            prt5.PortfolioName = "Builder Portfolio";

            PortfolioInvestmentAllocation set1 = new PortfolioInvestmentAllocation();
            set1.InvestmentAllocationId = 1;
            set1.InvestmentPortfolio = prt1;
            set1.ContributionPercPerPortfolio = 0.90;

            PortfolioInvestmentAllocation set2 = new PortfolioInvestmentAllocation();
            set2.InvestmentAllocationId = 2;
            set2.InvestmentPortfolio = prt2;
            set2.ContributionPercPerPortfolio = 0.10;

            si.InvestmentPortfolios.Add(set1);
            si.InvestmentPortfolios.Add(set2);



            Assert.AreEqual(true, actual: si.CheckPortfolioSum);




        }

        [TestMethod]
        public void CheckPortfolioSumMonthlyAndSingleTest()
        {

            SingleInvestment si = new SingleInvestment();

            si.SingleAmount = 200;
            si.InitialFinancialAdviserFee = 0.01;

            si.CalculateSingleInvestmentAmountAfterInitialFinancialAdviserFee();



            MonthlyInvestment mi = new MonthlyInvestment();

            mi.MonthlyAmount = 200;
            mi.InitialFinancialAdviserFee = 0.01;

            mi.CalculateMonthlyInvestmentAmountAfterInitialFinancialAdviserFee();


            Product p1 = new Product();
            p1.ProductName = "Optimum Living Annuity";
            Product p2 = new Product();
            p2.ProductName = "Optimum Retirement Annuity Fund";
            Product p3 = new Product();
            p3.ProductName = "Optimum Investment Plan";

            Portfolio prt1 = new Portfolio();
            prt1.PortfolioName = "N-e-FG Moderate Portfolio";
            Portfolio prt2 = new Portfolio();
            prt2.PortfolioName = "Consolidator Portfolio";
            Portfolio prt3 = new Portfolio();
            prt3.PortfolioName = "Institutional Cash Plus Account";
            Portfolio prt4 = new Portfolio();
            prt4.PortfolioName = "Protector Portfolio";
            Portfolio prt5 = new Portfolio();
            prt5.PortfolioName = "Builder Portfolio";

            PortfolioInvestmentAllocation set1 = new PortfolioInvestmentAllocation();
            set1.InvestmentAllocationId = 1;
            set1.InvestmentPortfolio = prt1;
            set1.ContributionPercPerPortfolio = 0.90;

            PortfolioInvestmentAllocation set2 = new PortfolioInvestmentAllocation();
            set2.InvestmentAllocationId = 2;
            set2.InvestmentPortfolio = prt2;
            set2.ContributionPercPerPortfolio = 0.10;

            mi.InvestmentPortfolios.Add(set1);
            mi.InvestmentPortfolios.Add(set2);

            si.SingleInvestmentPortfolios.Add(set1);
            si.SingleInvestmentPortfolios.Add(set2);


            Assert.AreEqual(true, actual: mi.CheckPortfolioSum);




        }
*/


    }
}
