using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.ViewDataSource
{
    public class PurchaseView
    {
        public string Product { set; get; }
        public DateTime ManufactureDate { set; get; }
        public DateTime ExpiredDate { set; get; }
        public int Quantity { set; get; }
        public double UnitPrice { set; get; }
        public double TotalPrice { set; get; }
        public string Remark { set; get; }
    }
}
