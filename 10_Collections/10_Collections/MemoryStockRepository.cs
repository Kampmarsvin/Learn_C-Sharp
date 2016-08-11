using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    public class MemoryStockRepository : IStockRepository
    {
        long id = 0;
        IDictionary contents = new Dictionary<long, Stock>();
        
        public long NextId()
        {
            return ++id;
        }

        public void SaveStock(Stock stock)
        {
            if (stock.Id == 0)
            {
                stock.Id = NextId();
            }
            if (!contents.Contains(id))
            contents.Add(stock.Id, stock);
        }

        public Stock LoadStock(long id)
        {
            return (Stock)contents[id];
        }

        public ICollection FindAllStocks()
        {
            return contents.Values;
        }

        public void Clear()
        {
            contents = new Dictionary<long, Stock>();
            id = 0;
        }
    }
}
