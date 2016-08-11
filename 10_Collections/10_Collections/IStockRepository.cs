using System.Collections;

namespace _10_Collections
{
    public interface IStockRepository
    {
        void Clear();
        ICollection FindAllStocks();
        Stock LoadStock(long id);
        long NextId();
        void SaveStock(Stock stock);
    }
}