using NEFGLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary.CompanyData;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TestingProgram.CompanyData
{
    [TestClass]
    public class MorningStarTests
    {
        [TestMethod]
        public void populateMorningStar()
        {
            var al = ApprovedListsTests.CreateApprovedList();

            MorningStar ms = new MorningStar();
            ms.MorningStarVersion = 1;
            ms.PortfolioHoldings = new List<PortfolioHolding>()
            {
                new PortfolioHolding(){
                    Holding = al.Holdings.First(),
                    Portfolio = al.Portfolios.First(),
                    MonthBaseValue = 0.30m // 30%
                }
            };

            var expectedPortofolioCount = 1;

            Assert.AreEqual(expectedPortofolioCount, ms.PortfolioHoldings.Count());
        }
    }
}
