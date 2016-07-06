using System;

namespace _09_Portfolio
{
    internal class ArrayPortfolio
    {
        private Asset[] stocks;
        int c;
        public ArrayPortfolio()
        {
            stocks = new Asset[10];
            c = 0;
        }

        public ArrayPortfolio(Asset[] stocks)
        {
            this.stocks = stocks;
            
        }

        internal double GetTotalValue()
        {
            double totalValue = 0;
            foreach (var item in stocks)
            {
                if (item != null)
                totalValue += item.GetValue();
            }
            return totalValue;
        }

        internal void AddAsset(Asset asset)
        {
            stocks[c++] = asset;
        }
    }
}