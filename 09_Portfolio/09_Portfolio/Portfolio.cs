using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        IList<Asset> assets;
        //IDictionary index = new Dictionary<string, Asset>();


        public Portfolio()
        {
            assets = new List<Asset>();
        }

        public Portfolio(List<Asset> assets)
        {
            this.assets = assets;
        }


        internal void AddAsset(Asset asset)
        {
            assets.Add(asset);
           // index.Add(asset.GetName(), asset);
        }

        internal IList<Asset> GetAssets()
        {
            return new ReadOnlyCollection<Asset>(assets);
        }

        
        internal double GetTotalValue()
        {
            double totalValue = 0;
            foreach (var item in assets)
            {
                if (item != null)
                    totalValue += item.GetValue();
            }
            return totalValue;
        }


    }
}