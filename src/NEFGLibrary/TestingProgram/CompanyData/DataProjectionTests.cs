using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary.CompanyData;

namespace TestingProgram.CompanyData
{
  [TestClass]
  public class DataProjectionTests
  {
    [TestMethod]
    public void ModifyGrowthPercentageTest()
    {
      //1
      var portfolioId = 1;
      var growthDataId = 1;
      var al = ApprovedListsTests.CreateApprovedList();
      var ms = new MorningStar
      {
        MorningStarVersion = 1,
        PortfolioGrowthDataInfo = new List<PortfolioGrowthData>
                {
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,1,1,0.065m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,2,1,0.08m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,3,1,0.09m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,4,1,0.09m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,5,1,0.075m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,6,1,0.095m),

                    PortfolioGrowthData.CreatePortfolioGrowthData(al,1,2,0.075m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,2,2,0.09m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,3,2,0.11m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,4,2,0.12m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,5,2,0.09m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,6,2,0.11m),

                    PortfolioGrowthData.CreatePortfolioGrowthData(al,1,3,0.085m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,2,3,0.1m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,3,3,0.13m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,4,3,0.15m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,5,3,0.105m),
                    PortfolioGrowthData.CreatePortfolioGrowthData(al,6,3,0.125m)                    
                }
      };
      //Assign
      var checkValue = 0.0651549723898189m;

      //Assert
      Assert.AreEqual(checkValue, DataProjection.ModifyGrowthPercentage(portfolioId, growthDataId, ms));
    }

  }
}
