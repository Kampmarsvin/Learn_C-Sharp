using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
    public class StockIO
    {
        public void WriteStock(TextWriter tw, Stock stock)
        {
            tw.WriteLine(stock.Symbol);
            tw.WriteLine(stock.PricePerShare);
            tw.WriteLine(stock.NumShares);
        }

        public Stock ReadStock(TextReader lines)
        {
            string symbol = lines.ReadLine();
            double price = Double.Parse(lines.ReadLine());
            int numShares = Int32.Parse(lines.ReadLine());
            return new Stock(symbol, price, numShares);
        }

        public void WriteStock(FileInfo file, Stock stock)
        {
            StreamWriter sw = new StreamWriter(file.ToString());
            WriteStock(sw, stock);
            sw.Close();   
        }
       

        public Stock ReadStock(FileInfo file)
        {
            StreamReader input = new StreamReader(file.ToString());
            Stock stock = ReadStock(input);
            input.Close(); // todo: finally
            return stock;
        }
        
    }
}
