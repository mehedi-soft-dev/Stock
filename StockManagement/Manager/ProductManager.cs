using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;
using StockManagement.Repository;

namespace StockManagement.Manager
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public List<Product> Display()
        {
            return _productRepository.Display();
        }

        public bool IsCodeExist(string code)
        {
            return _productRepository.IsCodeExist(code);
        }

        public bool IsNameExist(string name)
        {
            return _productRepository.IsNameExist(name);
        }

        public List<Product> Search(string searchKeyword)
        {
            return _productRepository.Search(searchKeyword);
        }

        public List<Category> ComboItem()
        {
            return _categoryRepository.Display();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productRepository.GetProductsByCategory(categoryId);
        }

        public Product SearchProductById(int id)
        {
            return _productRepository.SearchProductById(id);
        }
    }
}
