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

    }
}
