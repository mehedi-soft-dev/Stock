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
    
    public partial class CustomerUserControl : UserControl
    {
        CusotmerManager _cusotmerManager = new CusotmerManager();
        Customer _customer;


        public CustomerUserControl()
        {
            InitializeComponent();
            showDataGridView.DataSource = _cusotmerManager.Display();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(!IsValid())
                return;

            _customer = new Customer(codeTextBox.Text,nameTextBox.Text,addressTextBox.Text,contactTextBox.Text,emailTextBox.Text,Convert.ToInt32(loyalityPointTextBox.Text));

            if (_cusotmerManager.IsCodeExist(_customer.Code))
            {
                MessageBox.Show($"Code : {_customer.Code} Already Exist..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_cusotmerManager.IsNameExist(_customer.Name))
            {
                MessageBox.Show($"Name : {_customer.Name} Already Exist..!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_cusotmerManager.AddCustomer(_customer))
            {
                showDataGridView.DataSource = _cusotmerManager.Display();
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
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                emailErrorLabel.Text = "Please Enter Email";
                return false;
            }
            else
            {
                emailErrorLabel.ResetText();
            }

            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                contactErrorLabel.Text = "Please Enter Contact Number";
                return false;
            }
            else
            {
                contactErrorLabel.ResetText();
            }

            return true;

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _cusotmerManager.Search(searchTextBox.Text);
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
            if (!String.IsNullOrEmpty(emailTextBox.Text))
                emailErrorLabel.ResetText();
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(contactTextBox.Text))
                codeErrorLabel.ResetText();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
    }
}
