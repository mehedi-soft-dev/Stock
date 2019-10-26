using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    public class Stock
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public int OpeningBalance { set; get; }
        public int In { set; get; }
        public  int Out { set; get; }
        public int ClosingBalanace { set; get; }
    }
}
