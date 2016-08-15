using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
    public class FileStockRepository : IFileRepository
    {
        long id = 0;
        private DirectoryInfo directory;

        public FileStockRepository(DirectoryInfo directory)
        {
            if (!directory.Exists)
            {
                directory.Create();
            }
            this.directory = directory;
        }

        public long NextId()
        {
            return ++id;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public ICollection FindAllStocks()
        {
            throw new NotImplementedException();
        }

        public Stock LoadStock(long id)
        {
            return new StockIO().ReadStock(StockFile(id));
        }

        public void SaveStock(Stock stock)
        {
            if (stock.Id == 0)
            {
                stock.Id = NextId();
            }
            FileInfo file = StockFile(stock);
            new StockIO().WriteStock(file, stock);
        }

        private FileInfo StockFile(Stock stock)
        {
            FileInfo file = StockFile(stock.Id);
            return file;
        }
        private FileInfo StockFile(long id)
        {
            FileInfo file = new FileInfo(directory + StockFileName(id));
            return file;
        }

        public string StockFileName(long id)
        {
            return "stock" + id + ".txt";
        }
        public string StockFileName(Stock stock)
        {
            return StockFileName(stock.Id);
        }
    }
}
