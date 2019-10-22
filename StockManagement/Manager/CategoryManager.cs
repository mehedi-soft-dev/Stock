using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;
using StockManagement.Repository;


namespace StockManagement.Manager
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool AddCategory(Category category)
        {
            return _categoryRepository.AddCategory(category);
        }

        public List<Category> Display()
        {
            return _categoryRepository.Display();
        }

        public List<Category> SearchByName(string searchKeyword)
        {
            return _categoryRepository.SearchByName(searchKeyword);
        }

        public List<Category> CategoryComboItem()
        {
            return _categoryRepository.CategoryComboItem();
        }
    }
}
