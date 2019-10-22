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
            _customer = new Customer(codeTextBox.Text,nameTextBox.Text,addressTextBox.Text,contactTextBox.Text,emailTextBox.Text,Convert.ToInt32(loyalityPointTextBox.Text));

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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _cusotmerManager.SearchByName(searchTextBox.Text);
        }
    }
}
