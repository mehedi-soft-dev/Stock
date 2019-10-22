using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Model;
using StockManagement.Manager;

namespace StockManagement.Design
{
    public partial class CategoryUserControl : UserControl
    {
        CategoryManager _categoryManager = new CategoryManager();
        Category _category;

        public CategoryUserControl()
        {
            InitializeComponent();
            showDataGridView.DataSource = _categoryManager.Display();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _category = new Category(codeTextBox.Text, nameTextBox.Text);

            if (_categoryManager.AddCategory(_category))
            {
                showDataGridView.DataSource = _categoryManager.Display();
                MessageBox.Show("Added Successfully..!");
            }
            else
            {
                MessageBox.Show("Failed..!");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _categoryManager.SearchByName(searchTextBox.Text);
        }
    }
}
