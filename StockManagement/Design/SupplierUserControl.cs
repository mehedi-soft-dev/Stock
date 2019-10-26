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
    public partial class SupplierUserControl : UserControl
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier _supplier;

        public SupplierUserControl()
        {
            InitializeComponent();
            showDataGridView.DataSource = _supplierManager.Display();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(!IsValid())
                return;

            _supplier = new Supplier(codeTextBox.Text, nameTextBox.Text, addressTextBox.Text, contactTextBox.Text, emailTextBox.Text, contactPersonTextBox.Text);

            if (_supplierManager.IsCodeExist(_supplier.Code))
            {
                MessageBox.Show($"Code : {_supplier.Code} Already Exist..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_supplierManager.IsNameExist(_supplier.Name))
            {
                MessageBox.Show($"Name : {_supplier.Name} Already Exist..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_supplierManager.AddSupplier(_supplier))
            {
                showDataGridView.DataSource = _supplierManager.Display();
                MessageBox.Show("Suppler Added Successfully..!", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Supplier Added Failed!", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                nameErrorLabel.ResetText();
            }
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                contactErrorLabel.Text = "Please Enter Contact";
                return false;
            }
            else
            {
                contactErrorLabel.ResetText();
            }

            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                emailErrorLabel.Text = "Please Enter Email";
                return false;
            }
            else
            {
                emailErrorLabel.ResetText();
            }

            return true;
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(codeTextBox.Text))
                codeErrorLabel.ResetText();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(nameTextBox.Text))
                nameErrorLabel.ResetText();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(contactTextBox.Text))
                contactErrorLabel.ResetText();
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(emailTextBox.Text))
                emailErrorLabel.ResetText();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            showDataGridView.DataSource = null;
            showDataGridView.DataSource = _supplierManager.Search(searchTextBox.Text);
        }
    }
}
