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

            if (!IsValid())
            {
                return;
            }

            _category = new Category(codeTextBox.Text, nameTextBox.Text);

            if (_categoryManager.IsCodeExist(_category.Code))
            {
                MessageBox.Show($"Code : {_category.Code} Already Exist..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_categoryManager.IsNameExist(_category.Name))
            {
                MessageBox.Show($"Name : {_category.Name} Already Exist..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

        private bool IsValid()
        {
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
                nameErrorLabel.Text = "Please Enter Name";
                return false;
            }
            else
            {
                codeErrorLabel.ResetText();
            }

            return true;

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _categoryManager.SearchByName(searchTextBox.Text);
        }

        private void codeTextBox_Leave(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(codeTextBox.Text))
                codeErrorLabel.ResetText();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nameTextBox.Text))
                nameErrorLabel.ResetText();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
    }
}
