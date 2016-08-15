using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
    interface IStockRepository
    {
        void Clear();
        ICollection FindAllStocks();
        Stock LoadStock(long id);
        long NextId();
        void SaveStock(Stock stock);
    }
}
