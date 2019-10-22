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
    public partial class ProductUserControl : UserControl
    {
        ProductManager _productManager = new ProductManager();
        CategoryManager _categoryManager = new CategoryManager();
        Product _product;


        public ProductUserControl()
        {
            InitializeComponent();
            categoryComboBox.DataSource = _categoryManager.CategoryComboItem();
            showDataGridView.DataSource = _productManager.Display();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _product = new Product(Convert.ToInt32(categoryComboBox.SelectedValue), codeTextBox.Text, nameTextBox.Text, Convert.ToInt32(reorderLevelTextBox.Text), descriptionTextBox.Text);
            if (_productManager.AddProduct(_product))
            {
                showDataGridView.DataSource = _productManager.Display();
                MessageBox.Show("Added Successfully..!");
            }
            else
            {
                MessageBox.Show("Failed..!");
            }
        }
    }
}
