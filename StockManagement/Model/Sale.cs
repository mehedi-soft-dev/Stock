using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    public class Sale
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Sale() { }

        public Sale(DateTime date, int customerId, int productId, int quantity, double price)
        {
            this.Date = date;
            this.CustomerID = customerId;
            this.ProductID = productId;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}
