using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    public class StockValueComparator : IComparer<Asset>
    {
        

        public int Compare(Asset a, Asset b)
        {
            double aVal = ((Asset)a).GetValue();
            double bVal = ((Asset)b).GetValue();
            if (aVal == bVal) return 0;
            if (aVal > bVal) return -1;
            return 1;
        }
    }
}
