using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    public class Product
    {
        public int ID { set; get; }
        public int CategoryID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int ReOrderLevel { set; get; }
        public string Description { set; get; }

        public Product()
        {

        }

        public Product(int categoryId, string code, string name, int reOrderLevel, string description)
        {
            this.CategoryID = categoryId;
            this.Code = code;
            this.Name = name;
            this.ReOrderLevel = reOrderLevel;
            this.Description = description;
        }

    }
}
