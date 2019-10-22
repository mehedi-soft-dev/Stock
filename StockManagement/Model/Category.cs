using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    public class Category
    {
        public int ID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }

        public Category() { }
        public Category(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        
    }
}
