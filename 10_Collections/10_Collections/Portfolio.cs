using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _10_Collections
{
    internal class Portfolio
    {
        List<Asset> assets;
        IDictionary index = new Dictionary<string, Asset>();
    
        
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
            index.Add(asset.GetName(), asset);
        }

        internal IList<Asset> GetAssets()
        {
            return new ReadOnlyCollection<Asset>(assets);
        }

        internal Asset GetAssetByName(string name)
        {
            return (Asset)index[name];
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

        internal IList<Asset> GetAssetsSortedByName()
        {
            assets.Sort(new StockNameComparator());
            return GetAssets();
            
        }

        internal IList<Asset> GetAssetsSortedByValue()
        {
            assets.Sort(new StockValueComparator());
            return GetAssets();
        }
    }
}