using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Portfolio
{
    //Now things are getting trickier. Be sure to follow along in the index.html file, to see the purpose of the different tests
    //we will be creating here.

    //THESE ARE THE THIRD TESTS YOU SHOULD DO 

    [TestClass]
    public class PortFolioTests
    {


        Stock stockHP = new Stock("HPQ", 60.03, 120);
        Stock stockIBM = new Stock("IBM", 32.11, 50);
        SavingsAccount cd1000 = new SavingsAccount("Account 556677", 1000, 4.5);


        [TestMethod]
        public void ArrayConstructor()
        {
            Stock[] stocks = { stockHP, stockIBM };
            ArrayPortfolio portfolio = new ArrayPortfolio(stocks);
            Assert.AreEqual(8809.1, portfolio.GetTotalValue());
        }

        [TestMethod]
        public void Add()
        {
            ArrayPortfolio portfolio = new ArrayPortfolio();
            portfolio.AddAsset(stockHP);
            portfolio.AddAsset(stockIBM);
            portfolio.AddAsset(cd1000);
            Assert.AreEqual(9809.1, portfolio.GetTotalValue());
        }


    }
}
