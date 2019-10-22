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
using StockManagement.Repository;

namespace StockManagement.Design
{
    public partial class PurchaseUserControl : UserControl
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        CategoryRepository _categoryRepository = new CategoryRepository();
        ProductRepository _productRepository = new ProductRepository();

        private Product product;

        public PurchaseUserControl()
        {
            InitializeComponent();
            supplierComboBox.DataSource = _supplierRepository.SupplierComboItem();
            categoryComboBox.DataSource = _categoryRepository.CategoryComboItem();
        }

        private void manufacturedDatePicker_ValueChanged(object sender, EventArgs e)
        {
            manufacturedDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void manufacturedDatePicker_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                manufacturedDatePicker.CustomFormat = "--/--/----";
        }

        private void expireDatePicker_ValueChanged(object sender, EventArgs e)
        {
            expireDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void expireDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                expireDatePicker.CustomFormat = "--/--/----";
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            productComboBox.DataSource = _productRepository.GetProductsByCategory(Convert.ToInt32(categoryComboBox.SelectedValue));
        }

        private void productComboBox_TextChanged(object sender, EventArgs e)
        {
            product = _productRepository.SearchProductById(Convert.ToInt32(productComboBox.SelectedValue));

            codeTextBox.Text = product.Code;
        }
    }
}
