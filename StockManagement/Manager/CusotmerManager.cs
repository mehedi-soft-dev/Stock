using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;
using StockManagement.Repository;

namespace StockManagement.Manager
{
    public class CusotmerManager
    {
        CustomerRepository _cutomerRepository = new CustomerRepository();

        public bool AddCustomer(Customer customer)
        {
            return _cutomerRepository.AddCustomer(customer);
        }

        public List<Customer> Display()
        {
            return _cutomerRepository.Display();
        }

        public List<Customer> SearchByName(string searchKeyword)
        {
            return _cutomerRepository.SearchByName(searchKeyword);
        }
    }
}
