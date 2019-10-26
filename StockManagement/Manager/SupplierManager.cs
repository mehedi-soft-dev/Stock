using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;
using StockManagement.Repository;

namespace StockManagement.Manager
{
    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        ProductRepository _productRepository = new ProductRepository();

        public bool AddSupplier(Supplier supplier)
        {
            return _supplierRepository.AddSupplier(supplier);
        }

        public List<Supplier> Display()
        {
            return _supplierRepository.Display();
        }

        public List<Supplier> SupplierComboItem()
        {
            return _supplierRepository.SupplierComboItem();
        }

        public List<Supplier> Search(string searchKeyword)
        {
            return _supplierRepository.Search(searchKeyword);
        }

        public bool IsCodeExist(string code)
        {
            return _supplierRepository.IsCodeExist(code);
        }

        public bool IsNameExist(string name)
        {
            return _supplierRepository.IsNameExist(name);
        }

    }
}
