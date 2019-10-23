using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    public class Purchase
    {
        public int ID { set; get; }
        public DateTime Date { set; get; }
        public string InvoiceNo { set; get; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }

        public Purchase() { }

        public Purchase(DateTime date, string invoiceNo, int supplierId, int productId, int quantity, double unitPrice, double mrp)
        {
            this.Date = date;
            this.InvoiceNo = invoiceNo;
            this.SupplierID = supplierId;
            this.ProductID = productId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.MRP = mrp;
        }
    }
}
