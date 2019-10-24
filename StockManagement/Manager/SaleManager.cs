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

        public bool AddSale(List<Sale> sales)
        {
            bool isAdded = false;
            foreach (Sale sale in sales)
            {
                isAdded = _saleRepository.AddSale(sale);
            }
            return isAdded;
        } 
    }
}
