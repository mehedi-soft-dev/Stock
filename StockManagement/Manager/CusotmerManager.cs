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

        public bool IsCodeExist(string code)
        {
            return _cutomerRepository.IsCodeExist(code);
        }

        public bool IsNameExist(string name)
        {
            return _cutomerRepository.IsNameExist(name);
        }

        public List<Customer> Search(string searchKeyword)
        {
            return _cutomerRepository.Search(searchKeyword);
        }

        public Customer SearchById(int id)
        {
            return _cutomerRepository.SearchById(id);
        }

        public List<Customer> CustomerComboItem()
        {
            return _cutomerRepository.CustomerComboItem();
        }
    }
}
