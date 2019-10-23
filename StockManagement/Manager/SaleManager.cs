using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Repository;
using StockManagement.Model;

namespace StockManagement.Manager
{
    public class SaleManager
    {
        SaleRepository _saleRepository = new SaleRepository();

        public bool AddSale(Sale sale)
        {
            return _saleRepository.AddSale(sale);
        } 
    }
}
