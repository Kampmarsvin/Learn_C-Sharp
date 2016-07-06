using System;

namespace _09_Portfolio
{
    internal class Stock : Asset
    {

        public Stock()
        {
        }

        public Stock(string v1, double v2, int v3)
        {
            Symbol = v1;
            PricePerShare = v2;
            NumShares = v3;
        }

        public string Symbol { get; set; }

        public double PricePerShare { get; set; }

        public int NumShares { get; set; }

        

       
        internal static double TotalValue(Asset[] stocks)
        {
            double totalValue = 0;
            foreach (var item in stocks)
            {
               totalValue += item.GetValue();
            }
            return totalValue;
        }

       

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            var newPricePerShare = PricePerShare.ToString().Replace(',', '.'); 
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + newPricePerShare + ",numShares=" + NumShares +"]";
        }

        public override bool Equals(object o)
        {
            Stock other = (Stock)o;
            return (other.Symbol.Equals(Symbol) &&
                    other.PricePerShare == PricePerShare &&
                    other.NumShares == NumShares);
        }

        public double GetValue()
        {
            return PricePerShare * NumShares;
        }
    }
}