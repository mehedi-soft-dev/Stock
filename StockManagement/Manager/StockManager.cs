using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;
using StockManagement.Repository;

namespace StockManagement.Manager
{
    public class StockManager
    {
        StockRepository _stockRepository = new StockRepository();

        public List<Stock> FullStocks()
        {
            return _stockRepository.FullStocks();
        }
    }
}
