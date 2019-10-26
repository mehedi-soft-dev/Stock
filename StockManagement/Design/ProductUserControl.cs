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
            if(!IsValid())
                return;

            _product = new Product(Convert.ToInt32(categoryComboBox.SelectedValue), codeTextBox.Text, nameTextBox.Text, Convert.ToInt32(reorderLevelTextBox.Text), descriptionTextBox.Text);

            if (_productManager.IsCodeExist(_product.Code))
            {
                MessageBox.Show($"Code : {_product.Code} Already Exist..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_productManager.IsNameExist(_product.Name))
            {
                MessageBox.Show($"Name : {_product.Name} Already Exist..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

        private bool IsValid()
        {
            if(Convert.ToInt32(categoryComboBox.SelectedValue) == 0)
            {
                categoryErrorLabel.Text = "Please Enter Code";
                return false;
            }
            else
            {
                categoryErrorLabel.ResetText();
            }

            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                codeErrorLabel.Text = "Please Enter Code";
                return false;
            }
            else
            {
                codeErrorLabel.ResetText();
            }

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                nameLabel.Text = "Please Enter Name";
                return false;
            }
            else
            {
                nameLabel.ResetText();
            }
            if (String.IsNullOrEmpty(reorderLevelTextBox.Text))
            {
                reorderLevelLabel.Text = "Please Enter Re-Order Level";
                return false;
            }
            else
            {
                reorderLevelLabel.ResetText();
            }

            return true;
        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            categoryErrorLabel.ResetText();
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(codeTextBox.Text))
                codeErrorLabel.ResetText();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(codeTextBox.Text))
                nameLabel.ResetText();
        }

        private void reorderLevelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(codeTextBox.Text))
                reorderLevelLabel.ResetText();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            showDataGridView.DataSource = null;
            showDataGridView.DataSource = _productManager.Search(searchTextBox.Text);
        }
    }
}
