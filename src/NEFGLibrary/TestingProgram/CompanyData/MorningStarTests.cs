using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEFGLibrary.CompanyData;

namespace TestingProgram.CompanyData {
  [TestClass]
  public class MorningStarTests {
    [TestMethod]
    public void PopulateMorningStar() {
      var al = ApprovedListsTests.CreateApprovedList();

      var ms = new MorningStar {
        MorningStarVersion = 1,
        PortfolioHoldings = new List<PortfolioHolding> {
          PortfolioHolding.CreatePortfolioHolding(al, 1, 1, 0.299999999992319m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 2, 0.299999999979286m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 3, 0.299999999987181m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 4, 0.100000000041212m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 5, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 6, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 7, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 8, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 9, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 10, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 11, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 12, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 13, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 14, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 15, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 1, 16, 0m),

          PortfolioHolding.CreatePortfolioHolding(al, 2, 1, 0.139999999986001m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 2, 0.159999999986477m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 3, 0.0399999999955741m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 4, 0.300000000067094m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 5, 0.159999999986257m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 6, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 7, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 8, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 9, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 10, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 11, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 12, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 13, 0.199999999978594m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 14, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 15, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 2, 16, 0m),

          PortfolioHolding.CreatePortfolioHolding(al, 3, 1, 0.0499999999994014m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 2, 0.0500000000002091m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 3, 0.0399999999992592m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 4, 0.0500000000014901m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 5, 0.100000000000717m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 6, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 7, 0.0600000000003879m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 8, 0.100000000000571m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 9, 0.100000000000609m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 10, 0.250000000000334m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 11, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 12, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 13, 0.19999999999702m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 14, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 15, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 3, 16, 0m),

          PortfolioHolding.CreatePortfolioHolding(al, 4, 1, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 2, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 3, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 4, 0.0499999999993488m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 5, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 6, 0.120000000002058m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 7, 0.160000000000655m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 8, 0.0500000000001939m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 9, 0.170000000000562m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 10, 0.250000000000633m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 11, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 12, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 13, 0.199999999996546m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 14, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 15, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 4, 16, 0m),

          PortfolioHolding.CreatePortfolioHolding(al, 5, 1, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 2, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 3, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 4, 0.34000000000167m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 5, 0.329999999998949m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 6, 0.32999999999938m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 7, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 8, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 9, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 10, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 11, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 12, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 13, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 14, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 15, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 5, 16, 0m),

          PortfolioHolding.CreatePortfolioHolding(al, 6, 1, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 2, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 3, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 4, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 5, 0.329999999999954m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 6, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 7, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 8, 0.330000000000022m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 9, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 10, 0.340000000000023m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 11, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 12, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 13, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 14, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 15, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 6, 16, 0m),

          PortfolioHolding.CreatePortfolioHolding(al, 7, 1, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 2, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 3, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 4, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 5, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 6, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 7, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 8, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 9, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 10, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 11, 0.33000000000055m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 12, 0.329999999999729m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 13, 0.33999999999972m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 14, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 15, 0m),
          PortfolioHolding.CreatePortfolioHolding(al, 7, 16, 0m)
        }
      };

      var expectedPortofolioCount = 112;

      Assert.AreEqual(expectedPortofolioCount, ms.PortfolioHoldings.Count);
    }

    [TestMethod]
    public void PopulateMorningStarGrowthData()
        {
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

            var expectedGrowthCount = 18;
            Assert.AreEqual(expectedGrowthCount, ms.PortfolioGrowthDataInfo.Count);
        }

    [TestMethod]
    public void PopulateMorningStarAssets() {
      var al = ApprovedListsTests.CreateApprovedList();
       
      var ms = new MorningStar {
        MorningStarVersion = 1,
        PortfolioAssets = new List<PortfolioAsset> {
          //PortfolioHolding.CreatePortfolioHolding(al,1,1,0.299999999992319m),
          PortfolioAsset.CreatePortfolioAsset(al, 1, 1, 0.167085114028307m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 1, 0.106806965480087m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 1, 0.0606810477051777m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 1, 0.265221431010556m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 1, 0.0890288959880805m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 1, 0.105371456441572m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 1, 0.0135384462450103m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 2, 0.405692877527621m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 2, 0.214191395483572m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 2, 0.181072783783859m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 2, 0.651162819871336m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 2, 0.394113648691401m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 2, 0.140485338386054m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 2, 0.0104816665040104m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 3, 0.0183407162464318m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 3, 0.0279962119421395m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 3, 0.0252641193725367m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 3, 0.0183880524411697m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 3, 0.0352737074772086m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 3, 0.0600489927784541m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 3, 0.033845304280525m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 4, 0.00450112882741438m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 4, 0.00520365505283073m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 4, 0.00786008458749137m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 4, 0.00210083841951375m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 4, 0.0111585600921783m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 4, 0.00826077946328887m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 4, 0.000110062770723966m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 5, 0.0345652921834082m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 5, 0.0308828630715075m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 5, 0.0331503522497693m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 5, 0.00472925887751405m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 5, 0.0816923169756816m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 5, 0.0659527360123669m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 5, 0.00544705380981975m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 6, 0.0141248569671607m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 6, 0.00929626772160045m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 6, 0.0157528277344345m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 6, 0.0156140787838222m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 6, 0.0347381406632759m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 6, 0.0127261683706246m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 6, 0.00276444051184674m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 7, 0.00616097726093882m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 7, 0.00841119148782274m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 7, 0.011288596126108m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 7, 0.00643960638313652m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 7, 0.00732381846529835m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 7, 0.00542843450362781m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 7, 0.00162468406622535m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 8, 0.00126065928830001m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 8, 0.000748913910090945m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 8, 0.00142436550513549m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 8, 0.000222341220443444m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 8, 0.00389166550190674m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 8, 0.00133968435489584m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 8, 0.00207494170362398m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 9, 0.239088012120581m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 9, 0.444744742226947m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 9, 0.491404885229922m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 9, 0.0229381162179061m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 9, 0.189364508495877m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 9, 0.422831352170859m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 9, 0.8150649942495m),

          PortfolioAsset.CreatePortfolioAsset(al, 1, 10, 0.109180365549837m),
          PortfolioAsset.CreatePortfolioAsset(al, 2, 10, 0.151717793623402m),
          PortfolioAsset.CreatePortfolioAsset(al, 3, 10, 0.172100937705565m),
          PortfolioAsset.CreatePortfolioAsset(al, 4, 10, 0.0131834567746027m),
          PortfolioAsset.CreatePortfolioAsset(al, 5, 10, 0.153414737649092m),
          PortfolioAsset.CreatePortfolioAsset(al, 6, 10, 0.177555057518257m),
          PortfolioAsset.CreatePortfolioAsset(al, 7, 10, 0.115048405858714m)
        }
      };

      var expectedAssetCount = 70;

      Assert.AreEqual(expectedAssetCount, ms.PortfolioAssets.Count);
    }
  }
}